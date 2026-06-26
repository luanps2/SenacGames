// =============================================================================
// SenacGames.Desktop - UserControls/PerfilUserControl.cs
// =============================================================================
//  CONCEITO: UserControl de Perfil do Usuário
//
// Exibe as informações do usuário atualmente logado.
// Dados obtidos do SessionManager (armazenados após o login).
// =============================================================================

using SenacGames.Desktop.Helpers;
using SenacGames.Desktop.Services;
using SenacGames.Desktop.Themes;

namespace SenacGames.Desktop.UserControls
{
    /// <summary>
    /// Tela de perfil do usuário logado.
    /// </summary>
    public partial class PerfilUserControl : UserControl
    {
        // =====================================================================
        // SERVIÇOS (inicializados no Load)
        // =====================================================================
        private AuthApiService _authService = null!;

        // =====================================================================
        // CONSTRUTOR
        // =====================================================================

        /// <summary>
        /// Construtor padrão sem parâmetros — compatível com o Designer.
        /// </summary>
        public PerfilUserControl()
        {
            InitializeComponent();
        }

        // =====================================================================
        // EVENTO LOAD
        // =====================================================================

        private void PerfilUserControl_Load(object sender, EventArgs e)
        {
            // Guard: não executa em tempo de design
            if (DesignMode) return;

            // Inicializa serviço
            _authService = new AuthApiService();

            // Preenche dados de sessão nos controles
            var displayName = SessionManager.Instance.GetDisplayName();
            var email = SessionManager.Instance.GetEmail();
            var isAdmin = SessionManager.Instance.IsAdmin;

            // Atualiza avatar (inicial do nome)
            lblAvatar.Text = displayName.Length > 0
                ? displayName.Substring(0, 1).ToUpper()
                : "U";

            // Atualiza labels
            lblNome.Text = displayName;
            lblEmailValor.Text = email;
            lblApiValor.Text = AppConfig.ApiBaseUrl;

            // Badge de perfil
            var perfil = isAdmin ? "🔑 Administrador" : "👁 Usuário Comum";
            var corBadge = isAdmin ? SenacTheme.LaranjaPrimario : SenacTheme.AzulVariante;
            lblBadge.Text = perfil;
            lblBadge.BackColor = corBadge;

            // Roles
            var roles = SessionManager.Instance.CurrentUser?.Roles ?? new List<string>();
            lblRolesValor.Text = roles.Count > 0
                ? string.Join(", ", roles)
                : "Sem perfil atribuído";
        }
    }
}
