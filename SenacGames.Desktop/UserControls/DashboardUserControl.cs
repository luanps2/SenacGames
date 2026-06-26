// =============================================================================
// SenacGames.Desktop - UserControls/DashboardUserControl.cs
// =============================================================================
//  CONCEITO: UserControl de Dashboard
//
// O Dashboard exibe uma visão geral do sistema:
//   - Cards com métricas (total de games, categorias, usuários)
//   - Lista dos últimos games cadastrados
//   - Saudação personalizada para o usuário logado
//
// Como os dados chegam?
//   DashboardUserControl  GamesApiService  GET /api/games
//   DashboardUserControl  CategoriasApiService  GET /api/categories
// =============================================================================

using SenacGames.Desktop.Helpers;
using SenacGames.Desktop.Services;
using SenacGames.Desktop.Themes;

namespace SenacGames.Desktop.UserControls
{
    /// <summary>
    /// Dashboard do SenacGames Desktop.
    /// Exibe métricas e últimos registros do sistema.
    /// </summary>
    public partial class DashboardUserControl : UserControl
    {
        // =====================================================================
        // SERVIÇOS (inicializados no Load, nunca no construtor)
        // =====================================================================
        private GamesApiService _gamesService = null!;
        private CategoriasApiService _categoriasService = null!;

        // =====================================================================
        // CONSTRUTOR
        // =====================================================================

        /// <summary>
        /// Construtor padrão sem parâmetros — compatível com o Designer.
        /// </summary>
        public DashboardUserControl()
        {
            InitializeComponent();
        }

        // =====================================================================
        // EVENTO LOAD
        // =====================================================================

        private async void DashboardUserControl_Load(object sender, EventArgs e)
        {
            // Guard: não executa em tempo de design
            if (DesignMode) return;

            // Inicializa serviços
            _gamesService = new GamesApiService();
            _categoriasService = new CategoriasApiService();

            // Preenche dados dinâmicos de sessão
            lblTitulo.Text = $"Olá, {SessionManager.Instance.GetDisplayName()}! 👋";
            lblSubtitulo.Text = $"Bem-vindo ao SenacGames Desktop — {DateTime.Now:dddd, dd 'de' MMMM 'de' yyyy}";

            // Aplica estilo ao grid
            SenacTheme.AplicarEstiloGrid(gridUltimosGames);

            // Carrega dados da API
            await CarregarDadosAsync();
        }

        // =====================================================================
        // CARREGAMENTO DE DADOS
        // =====================================================================

        /// <summary>
        /// Carrega dados da API e atualiza os cards e a grid.
        /// </summary>
        private async Task CarregarDadosAsync()
        {
            SetCarregando(true);

            try
            {
                var tarefaGames = _gamesService.GetAllAsync();
                var tarefaCategorias = _categoriasService.GetAllAsync();
                await Task.WhenAll(tarefaGames, tarefaCategorias);

                var games = tarefaGames.Result;
                var categorias = tarefaCategorias.Result;

                // Atualiza os cards de métricas
                AtualizarNumeroCard(cardGames, games.Count.ToString());
                AtualizarNumeroCard(cardCategorias, categorias.Count.ToString());

                // Popula a grid com os últimos 10 games
                gridUltimosGames.Rows.Clear();
                foreach (var g in games.OrderByDescending(x => x.CreatedAt).Take(10))
                {
                    gridUltimosGames.Rows.Add(
                        g.Id,
                        g.Title,
                        g.CategoryName,
                        g.ReleaseYear,
                        g.IsFeatured,
                        g.CreatedAt.ToString("dd/MM/yyyy HH:mm"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erro ao carregar dados: {ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            finally
            {
                SetCarregando(false);
            }
        }

        // =====================================================================
        // AUXILIARES
        // =====================================================================

        /// <summary>
        /// Atualiza o número exibido em um card de métrica.
        /// </summary>
        private void AtualizarNumeroCard(Guna.UI2.WinForms.Guna2Panel card, string numero)
        {
            var lblNumero = card.Controls.OfType<Label>().FirstOrDefault(l => l.Tag?.ToString() == "numero");
            if (lblNumero != null)
                lblNumero.Text = numero;
        }

        private void SetCarregando(bool carregando)
        {
            lblCarregando.Visible = carregando;
            cardGames.Visible = !carregando;
            cardCategorias.Visible = !carregando;
            lblUltimosGames.Visible = !carregando;
            gridUltimosGames.Visible = !carregando;
        }
    }
}
