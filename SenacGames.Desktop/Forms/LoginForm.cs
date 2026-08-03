// =============================================================================
// SenacGames.Desktop - Forms/LoginForm.cs
// =============================================================================
//  CONCEITO: Formulário de Login
//
// O LoginForm é a primeira tela exibida ao iniciar o aplicativo.
// Responsabilidades:
//   1. Exibir campos de e-mail e senha
//   2. Chamar AuthApiService para autenticar via API
//   3. Armazenar dados do usuário no SessionManager
//   4. Redirecionar para o MainForm após autenticação
// =============================================================================

using SenacGames.Desktop.Helpers;
using SenacGames.Desktop.Services;
using SenacGames.Desktop.Themes;

namespace SenacGames.Desktop.Forms
{
    /// <summary>
    /// Formulário de autenticação do SenacGames Desktop.
    /// Primeira tela exibida ao iniciar o aplicativo.
    /// </summary>
    public partial class LoginForm : Form
    {
        // =====================================================================
        // CAMPOS PRIVADOS
        // =====================================================================

        /// <summary>Serviço de autenticação — consome POST /api/auth/login</summary>
        private AuthApiService _authService = null!;

        // =====================================================================
        // CONSTRUTOR
        // =====================================================================

        /// <summary>
        /// Construtor padrão sem parâmetros — compatível com o Designer.
        /// Toda inicialização complexa ocorre no evento Load.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
        }

        // =====================================================================
        // EVENTO LOAD
        // =====================================================================

        /// <summary>
        /// Inicialização executada após o formulário ser carregado.
        /// Aqui inicializamos serviços e preenchemos dados dinâmicos.
        /// </summary>
        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Guard: não executa em tempo de design
            if (DesignMode) return;

            // Instancia o serviço de autenticação
            _authService = new AuthApiService();

            // Aplica o tema visual Senac
            AplicarTema();

            // Preenche labels com dados dinâmicos
            lblVersao.Text = $"Versão {AppConfig.Version} | © {DateTime.Now.Year} SENAC-SP";
            lblApi.Text = $"🌐 API: {AppConfig.ApiBaseUrl}";
        }

        // =====================================================================
        // TEMA
        // =====================================================================

        private void AplicarTema()
        {
            this.BackColor = SenacTheme.AzulPrimario;
        }

        // =====================================================================
        // EVENTOS DE TECLADO
        // =====================================================================

        private void TxtEmail_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtSenha.Focus();
        }

        private void TxtSenha_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnEntrar_Click(sender, e);
        }

        // =====================================================================
        // EVENTOS DE BOTÃO
        // =====================================================================

        /// <summary>
        /// Evento do botão Entrar.
        /// Valida os campos, chama a API e redireciona para o MainForm.
        /// </summary>
        private async void BtnEntrar_Click(object? sender, EventArgs e)
        {
            // Limpa mensagens anteriores
            ExibirErro(string.Empty);

            // ─── Validação de campos ────────────────────────────────────────
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                ExibirErro("⚠ Informe o e-mail.");
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                ExibirErro("⚠ Informe a senha.");
                txtSenha.Focus();
                return;
            }

            // ─── Estado de carregamento ─────────────────────────────────────
            SetCarregando(true);

            try
            {
                // ─── Chamada à API ──────────────────────────────────────────
                var (success, user, errorMessage) = await _authService.LoginAsync(
                    txtEmail.Text.Trim(),
                    txtSenha.Text);

                if (success && user != null)
                {
                    //  Login bem-sucedido!

                    // Armazena os dados do usuário na sessão (Singleton)
                    SessionManager.Instance.SetUser(user);

                    // Esconde o formulário de login
                    this.Hide();

                    // Abre o formulário principal
                    using var mainForm = new MainForm();
                    mainForm.ShowDialog();

                    // Quando o MainForm fechar, fecha o LoginForm também
                    this.Close();
                }
                else
                {
                    //  Login falhou — exibe mensagem de erro
                    ExibirErro($"❌ {errorMessage}");
                }
            }
            catch (HttpRequestException)
            {
                ExibirErro("❌ Não foi possível conectar à API.\nVerifique se a API está em execução.");
            }
            catch (Exception ex)
            {
                ExibirErro($"❌ Erro inesperado: {ex.Message}");
            }
            finally
            {
                SetCarregando(false);
            }
        }

        // =====================================================================
        // MÉTODOS AUXILIARES
        // =====================================================================

        /// <summary>
        /// Exibe ou oculta a mensagem de erro.
        /// </summary>
        private void ExibirErro(string mensagem)
        {
            if (string.IsNullOrEmpty(mensagem))
            {
                lblErro.Visible = false;
                lblErro.Text = string.Empty;
            }
            else
            {
                lblErro.Text = mensagem;
                lblErro.Visible = true;
            }
        }

        /// <summary>
        /// Ativa/desativa o modo de carregamento da interface.
        /// Impede cliques duplos e informa visualmente o usuário.
        /// </summary>
        private void SetCarregando(bool carregando)
        {
            //
            btnEntrar.Enabled = !carregando;
            txtEmail.Enabled = !carregando;
            txtSenha.Enabled = !carregando;
            lblCarregando.Visible = carregando;

            if (carregando)
            {
                btnEntrar.Text = "Aguarde...";
                lblErro.Visible = false;
            }
            else
            {
                btnEntrar.Text = "ENTRAR";
            }
        }
    }
}
