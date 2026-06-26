// =============================================================================
// SenacGames.Desktop - Forms/MainForm.cs
// =============================================================================
//  CONCEITO: Formulário Principal com Navegação por UserControls
//
// O MainForm é o "shell" (casca) da aplicação após o login.
// Ele NÃO usa MDI — usa o padrão moderno de NAVEGAÇÃO POR USERCONTROLS:
//    Um painel central (pnlConteudo) recebe UserControls dinamicamente
//    Uma sidebar lateral contém botões de navegação
//    Um cabeçalho superior exibe informações do usuário
// =============================================================================

using Guna.UI2.WinForms;
using SenacGames.Desktop.Helpers;
using SenacGames.Desktop.Services;
using SenacGames.Desktop.Themes;
using SenacGames.Desktop.UserControls;

namespace SenacGames.Desktop.Forms
{
    /// <summary>
    /// Formulário principal do SenacGames Desktop.
    /// Gerencia navegação entre módulos via UserControls.
    /// </summary>
    public partial class MainForm : Form
    {
        // =====================================================================
        // CAMPOS PRIVADOS
        // =====================================================================

        /// <summary>UserControl atualmente exibido no painel de conteúdo</summary>
        private UserControl? _controlAtual;

        /// <summary>Botão da sidebar atualmente ativo (destacado)</summary>
        private Guna2Button? _botaoAtivo;

        /// <summary>Serviço de autenticação para logout</summary>
        private AuthApiService _authService = null!;

        // =====================================================================
        // CONSTRUTOR
        // =====================================================================

        /// <summary>
        /// Construtor padrão sem parâmetros — compatível com o Designer.
        /// Toda inicialização complexa ocorre no evento Load.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        // =====================================================================
        // EVENTO LOAD
        // =====================================================================

        /// <summary>
        /// Inicialização executada após o formulário ser carregado.
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Guard: não executa em tempo de design
            if (DesignMode) return;

            // Instancia o serviço
            _authService = new AuthApiService();

            // Atualiza o título com a versão
            this.Text = $"SenacGames Desktop — {AppConfig.Version}";

            // Preenche dados dinâmicos de sessão no header
            lblTituloApp.Top = (SenacTheme.HeaderAltura - lblTituloApp.PreferredHeight) / 2;
            lblUsuario.Text = $"👤 {SessionManager.Instance.GetDisplayName()}";
            lblPerfil.Text = SessionManager.Instance.IsAdmin ? "🔑 Administrador" : "👁 Usuário Comum";
            lblPerfil.ForeColor = SessionManager.Instance.IsAdmin
                ? SenacTheme.LaranjaPrimario
                : SenacTheme.AzulVariante;
            lblSessao.Text = $"🟢 {SessionManager.Instance.GetEmail()}";

            // Configura permissões baseadas no perfil do usuário
            ConfigurarPermissoes();

            // Abre o Dashboard como tela inicial
            NavegarpParaDashboard();
        }

        // =====================================================================
        // EVENTOS DO DESIGNER
        // =====================================================================

        private void PnlHeader_Paint(object? sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(
                new Pen(SenacTheme.CinzaClaro, 1),
                0, pnlHeader.Height - 1,
                pnlHeader.Width, pnlHeader.Height - 1);
        }

        private void PnlHeader_Resize(object? sender, EventArgs e)
        {
            btnLogout.Location = new Point(pnlHeader.Width - 100, 13);
            // Encontra o painel de dados do usuário pelo nome e reposiciona
            var pnlUsuario = pnlHeader.Controls.OfType<Panel>().FirstOrDefault(p => p.Name == "pnlUsuario");
            if (pnlUsuario != null)
                pnlUsuario.Location = new Point(pnlHeader.Width - 300, 8);
        }

        // =====================================================================
        // EVENTOS DE NAVEGAÇÃO (botões da sidebar)
        // =====================================================================

        private void BtnDashboard_Click(object? sender, EventArgs e)
            => Navegar(new DashboardUserControl(), btnDashboard);

        private void BtnGames_Click(object? sender, EventArgs e)
            => Navegar(new GamesUserControl(), btnGames);

        private void BtnCategorias_Click(object? sender, EventArgs e)
            => Navegar(new CategoriasUserControl(), btnCategorias);

        private void BtnUsuarios_Click(object? sender, EventArgs e)
            => Navegar(new UsuariosUserControl(), btnUsuarios);

        private void BtnPerfil_Click(object? sender, EventArgs e)
            => Navegar(new PerfilUserControl(), btnPerfil);

        // =====================================================================
        // CONTROLE DE PERMISSÕES
        // =====================================================================

        /// <summary>
        /// Oculta/exibe itens da sidebar baseado no perfil do usuário.
        /// Admin: acesso total.
        /// Usuário Comum: apenas Dashboard e Games (somente leitura).
        /// </summary>
        private void ConfigurarPermissoes()
        {
            var isAdmin = SessionManager.Instance.IsAdmin;

            // Módulos exclusivos para Admin
            btnCategorias.Visible = isAdmin;
            btnUsuarios.Visible = isAdmin;
        }

        // =====================================================================
        // NAVEGAÇÃO
        // =====================================================================

        /// <summary>
        /// Navega para o Dashboard (tela inicial após login).
        /// </summary>
        private void NavegarpParaDashboard()
        {
            Navegar(new DashboardUserControl(), btnDashboard);
        }

        /// <summary>
        /// Carrega um UserControl no painel de conteúdo.
        /// </summary>
        private void Navegar(UserControl control, Guna2Button? botao = null)
        {
            // Remove o controle anterior
            if (_controlAtual != null)
            {
                pnlConteudo.Controls.Remove(_controlAtual);
                _controlAtual.Dispose();
                _controlAtual = null;
            }

            // Adiciona o novo controle
            control.Dock = DockStyle.Fill;
            pnlConteudo.Controls.Add(control);
            _controlAtual = control;

            // Atualiza visual dos botões da sidebar
            AtualizarBotaoAtivo(botao);
        }

        /// <summary>
        /// Aplica o estilo "ativo" ao botão clicado e remove dos outros.
        /// </summary>
        private void AtualizarBotaoAtivo(Guna2Button? botao)
        {
            if (_botaoAtivo != null)
            {
                _botaoAtivo.FillColor = Color.Transparent;
                _botaoAtivo.ForeColor = Color.White;
            }

            _botaoAtivo = botao;
            if (_botaoAtivo != null)
            {
                _botaoAtivo.FillColor = Color.FromArgb(0, 50, 110);
                _botaoAtivo.ForeColor = Color.White;
                _botaoAtivo.CustomBorderColor = SenacTheme.LaranjaPrimario;
            }
        }

        // =====================================================================
        // EVENTOS
        // =====================================================================

        /// <summary>
        /// Evento do botão de Logout.
        /// Confirma, chama a API de logout, limpa sessão e volta ao Login.
        /// </summary>
        private async void BtnLogout_Click(object? sender, EventArgs e)
        {
            var resposta = MessageBox.Show(
                "Deseja realmente sair do sistema?",
                "Confirmar Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta != DialogResult.Yes) return;

            try
            {
                await _authService.LogoutAsync();
            }
            catch
            {
                // Mesmo se a API falhar, limpamos a sessão local
            }
            finally
            {
                SessionManager.Instance.Clear();
                this.Close();
            }
        }
    }
}
