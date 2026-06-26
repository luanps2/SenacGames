// =============================================================================
// SenacGames.Desktop - UserControls/GamesUserControl.cs
// =============================================================================
//  CONCEITO: UserControl de CRUD de Games
//
// Este UserControl implementa o CRUD completo de games:
//   C  Create (criar)
//   R  Read (listar/buscar)
//   U  Update (editar)
//   D  Delete (excluir)
//
// Toda comunicação ocorre via GamesApiService.
// Controle de permissões: Admin vê todos os botões, usuário comum apenas lista.
// =============================================================================

using SenacGames.Desktop.DTOs;
using SenacGames.Desktop.Forms;
using SenacGames.Desktop.Helpers;
using SenacGames.Desktop.Services;
using SenacGames.Desktop.Themes;

namespace SenacGames.Desktop.UserControls
{
    /// <summary>
    /// Módulo de gerenciamento de Games.
    /// CRUD completo via API REST.
    /// </summary>
    public partial class GamesUserControl : UserControl
    {
        // =====================================================================
        // SERVIÇOS (inicializados no Load)
        // =====================================================================
        private GamesApiService _gamesService = null!;
        private CategoriasApiService _categoriasService = null!;

        // =====================================================================
        // DADOS
        // =====================================================================
        /// <summary>Lista completa de games (cache local)</summary>
        private List<GameResponseDto> _todosGames = new();
        /// <summary>Lista de categorias (para ComboBox)</summary>
        private List<CategoriaResponseDto> _categorias = new();

        // =====================================================================
        // CONSTRUTOR
        // =====================================================================

        /// <summary>
        /// Construtor padrão sem parâmetros — compatível com o Designer.
        /// </summary>
        public GamesUserControl()
        {
            InitializeComponent();
        }

        // =====================================================================
        // EVENTO LOAD
        // =====================================================================

        private async void GamesUserControl_Load(object sender, EventArgs e)
        {
            // Guard: não executa em tempo de design
            if (DesignMode) return;

            // Inicializa serviços
            _gamesService = new GamesApiService();
            _categoriasService = new CategoriasApiService();

            // Aplica estilo ao grid
            SenacTheme.AplicarEstiloGrid(gridGames);

            // Configura permissões
            ConfigurarPermissoes();

            // Carrega dados
            await CarregarDadosAsync();
        }

        // =====================================================================
        // PERMISSÕES
        // =====================================================================
        private void ConfigurarPermissoes()
        {
            bool isAdmin = SessionManager.Instance.IsAdmin;
            btnNovo.Visible = isAdmin;
            btnEditar.Visible = isAdmin;
            btnExcluir.Visible = isAdmin;
        }

        // =====================================================================
        // CARREGAMENTO DE DADOS
        // =====================================================================

        /// <summary>
        /// Carrega todos os games da API e popula o DataGridView.
        /// </summary>
        private async Task CarregarDadosAsync()
        {
            gridGames.Rows.Clear();

            try
            {
                var tarefaGames = _gamesService.GetAllAsync();
                var tarefaCategorias = _categoriasService.GetAllAsync();
                await Task.WhenAll(tarefaGames, tarefaCategorias);

                _todosGames = tarefaGames.Result;
                _categorias = tarefaCategorias.Result;

                PopularGrid(_todosGames);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar games: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PopularGrid(List<GameResponseDto> games)
        {
            gridGames.Rows.Clear();
            foreach (var g in games)
            {
                gridGames.Rows.Add(
                    g.Id,
                    g.Title,
                    g.CategoryName,
                    g.ReleaseYear,
                    g.IsFeatured,
                    g.CreatedAt.ToString("dd/MM/yyyy HH:mm"));
            }
        }

        // =====================================================================
        // PESQUISA
        // =====================================================================

        private void TxtPesquisa_TextChanged(object? sender, EventArgs e) => FiltrarGames();

        private void BtnPesquisar_Click(object? sender, EventArgs e) => FiltrarGames();

        private void FiltrarGames()
        {
            var termo = txtPesquisa.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(termo))
            {
                PopularGrid(_todosGames);
                return;
            }

            var filtrados = _todosGames
                .Where(g => g.Title.Contains(termo, StringComparison.OrdinalIgnoreCase)
                         || g.CategoryName.Contains(termo, StringComparison.OrdinalIgnoreCase))
                .ToList();

            PopularGrid(filtrados);
        }

        // =====================================================================
        // CRUD
        // =====================================================================

        private async void BtnNovo_Click(object? sender, EventArgs e)
        {
            using var form = new GameFormDialog(_categorias, null);
            if (form.ShowDialog() == DialogResult.OK && form.GameDto != null)
            {
                var (success, _, error) = await _gamesService.CreateAsync(form.GameDto);
                if (success)
                {
                    MessageBox.Show("✅ Game criado com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await CarregarDadosAsync();
                }
                else
                {
                    MessageBox.Show($"❌ {error}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void BtnEditar_Click(object? sender, EventArgs e)
        {
            var game = ObterGameSelecionado();
            if (game == null)
            {
                MessageBox.Show("Selecione um game para editar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var form = new GameFormDialog(_categorias, game);
            if (form.ShowDialog() == DialogResult.OK && form.UpdateDto != null)
            {
                var (success, _, error) = await _gamesService.UpdateAsync(game.Id, form.UpdateDto);
                if (success)
                {
                    MessageBox.Show("✅ Game atualizado com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await CarregarDadosAsync();
                }
                else
                {
                    MessageBox.Show($"❌ {error}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void BtnExcluir_Click(object? sender, EventArgs e)
        {
            var game = ObterGameSelecionado();
            if (game == null)
            {
                MessageBox.Show("Selecione um game para excluir.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var conf = MessageBox.Show(
                $"Tem certeza que deseja excluir o game:\n\"{game.Title}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (conf != DialogResult.Yes) return;

            var (success, error) = await _gamesService.DeleteAsync(game.Id);
            if (success)
            {
                MessageBox.Show("✅ Game excluído com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                await CarregarDadosAsync();
            }
            else
            {
                MessageBox.Show($"❌ {error}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnAtualizar_Click(object? sender, EventArgs e)
            => await CarregarDadosAsync();

        // =====================================================================
        // AUXILIARES
        // =====================================================================

        private GameResponseDto? ObterGameSelecionado()
        {
            if (gridGames.SelectedRows.Count == 0) return null;
            var row = gridGames.SelectedRows[0];
            var id = Convert.ToInt32(row.Cells["Id"].Value);
            return _todosGames.FirstOrDefault(g => g.Id == id);
        }

        private void GridGames_SelectionChanged(object? sender, EventArgs e)
        {
            // Pode adicionar preview da capa aqui futuramente
        }

        private void GridGames_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
            => BtnEditar_Click(sender, e);
    }
}
