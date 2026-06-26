// =============================================================================
// SenacGames.Desktop - UserControls/UsuariosUserControl.cs
// =============================================================================
//  CONCEITO: UserControl de Gerenciamento de Usuários
//
// Permite visualizar e gerenciar usuários do ASP.NET Core Identity via API.
// NOTA: Este módulo é exclusivo para Administradores.
// =============================================================================

using SenacGames.Desktop.DTOs;
using SenacGames.Desktop.Forms;
using SenacGames.Desktop.Services;
using SenacGames.Desktop.Themes;

namespace SenacGames.Desktop.UserControls
{
    /// <summary>
    /// Módulo de gerenciamento de Usuários do Identity.
    /// Exclusivo para Administradores.
    /// </summary>
    public partial class UsuariosUserControl : UserControl
    {
        // =====================================================================
        // SERVIÇOS E DADOS
        // =====================================================================
        private UsuariosApiService _usuariosService = null!;
        private List<UsuarioResponseDto> _usuarios = new();

        // =====================================================================
        // CONSTRUTOR
        // =====================================================================

        /// <summary>
        /// Construtor padrão sem parâmetros — compatível com o Designer.
        /// </summary>
        public UsuariosUserControl()
        {
            InitializeComponent();
        }

        // =====================================================================
        // EVENTO LOAD
        // =====================================================================

        private async void UsuariosUserControl_Load(object sender, EventArgs e)
        {
            // Guard: não executa em tempo de design
            if (DesignMode) return;

            // Inicializa serviço
            _usuariosService = new UsuariosApiService();

            // Aplica estilo ao grid
            SenacTheme.AplicarEstiloGrid(gridUsuarios);

            // Carrega dados
            await CarregarDadosAsync();
        }

        // =====================================================================
        // DADOS
        // =====================================================================
        private async Task CarregarDadosAsync()
        {
            gridUsuarios.Rows.Clear();
            try
            {
                _usuarios = await _usuariosService.GetAllAsync();

                if (_usuarios.Count == 0)
                {
                    var row = gridUsuarios.Rows.Add();
                    gridUsuarios.Rows[row].Cells["Id"].Value = "-";
                    gridUsuarios.Rows[row].Cells["Email"].Value =
                        "ℹ Endpoint /api/users não implementado na API. Adicione um UsersController.";
                    gridUsuarios.Rows[row].Cells["Perfil"].Value = "-";
                    return;
                }

                foreach (var u in _usuarios)
                    gridUsuarios.Rows.Add(u.Id, u.Email, u.PerfilPrincipal);
            }
            catch
            {
                var row = gridUsuarios.Rows.Add();
                gridUsuarios.Rows[row].Cells["Email"].Value =
                    "⚠ Não foi possível carregar usuários. Verifique se a API está online.";
            }
        }

        private void FiltrarUsuarios()
        {
            var termo = txtPesquisa.Text.Trim().ToLower();
            gridUsuarios.Rows.Clear();

            var filtrados = string.IsNullOrEmpty(termo)
                ? _usuarios
                : _usuarios.Where(u => u.Email.Contains(termo, StringComparison.OrdinalIgnoreCase)).ToList();

            foreach (var u in filtrados)
                gridUsuarios.Rows.Add(u.Id, u.Email, u.PerfilPrincipal);
        }

        // =====================================================================
        // EVENTOS DOS BOTÕES
        // =====================================================================

        private void TxtPesquisa_TextChanged(object? sender, EventArgs e)
            => FiltrarUsuarios();

        private async void BtnNovo_Click(object? sender, EventArgs e)
        {
            using var form = new UsuarioFormDialog();
            if (form.ShowDialog() == DialogResult.OK && form.CreateDto != null)
            {
                var (success, _, error) = await _usuariosService.CreateAsync(form.CreateDto);
                if (success)
                {
                    MessageBox.Show("✅ Usuário criado!", "Sucesso",
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
            if (gridUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um usuário.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var id = gridUsuarios.SelectedRows[0].Cells["Id"].Value?.ToString();
            var email = gridUsuarios.SelectedRows[0].Cells["Email"].Value?.ToString();

            if (string.IsNullOrEmpty(id) || id == "-") return;

            var conf = MessageBox.Show(
                $"Excluir o usuário \"{email}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (conf != DialogResult.Yes) return;

            var (success, error) = await _usuariosService.DeleteAsync(id);
            if (success)
            {
                MessageBox.Show("✅ Usuário excluído!", "Sucesso",
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
    }
}
