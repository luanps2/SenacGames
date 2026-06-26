// =============================================================================
// SenacGames.Desktop - Program.cs
// =============================================================================
//  CONCEITO: Ponto de entrada da aplicação Windows Forms.
//
// O método Main é o primeiro código executado quando o aplicativo inicia.
// Aqui configuramos:
//   1. Modo de alto DPI (telas de alta resolução)
//   2. Estilo visual do aplicativo
//   3. Descoberta automática da URL da API
//   4. Validação de disponibilidade da API (opcional, não-bloqueante)
//   5. Inicialização do formulário de Login
//
// ====================================================
// FLUXO DE INICIALIZAÇÃO
// ====================================================
//
//  Program.Main()
//       │
//       ▼
//  ApiEndpointResolver.Resolve()
//       │
//       ├──  URL encontrada  log no Output  continua
//       │
//       └──  URL não encontrada  MessageBox amigável  encerra
//       │
//       ▼
//  HttpClientHelper.PingApiAsync()  [opcional, 5s timeout]
//       │
//       ├──  API respondeu  abre LoginForm normalmente
//       │
//       └──  API offline  MessageBox de aviso  abre LoginForm mesmo assim
//             (usuário pode iniciar a API e tentar fazer login)
//       │
//       ▼
//  Application.Run(LoginForm)
//
// ====================================================
// POR QUE VERIFICAR A API NA INICIALIZAÇÃO?
// ====================================================
//
// Sem verificação: o usuário preenche email e senha, clica "Entrar",
// e só então descobre que a API está offline. UX ruim.
//
// Com verificação: o usuário vê logo ao abrir o app que a API não
// está disponível, antes mesmo de tentar fazer login. UX melhor.
//
// A verificação é NÃO-BLOQUEANTE: se a API estiver offline, o usuário
// vê o aviso mas PODE continuar (talvez vá iniciar a API agora).
// =============================================================================

namespace SenacGames.Desktop;

using SenacGames.Desktop.Helpers;

/// <summary>
/// Classe principal de inicialização da aplicação Desktop.
/// </summary>
static class Program
{
    /// <summary>
    /// Ponto de entrada principal da aplicação.
    /// [STAThread] é necessário para Windows Forms (Single-Threaded Apartment).
    /// </summary>
    [STAThread]
    static void Main()
    {
        // Configura o aplicativo para suportar visual styles modernos do Windows
        // (Necessário para o Guna.UI2 funcionar corretamente)
        ApplicationConfiguration.Initialize();

        // ── PASSO 1: Descoberta automática da URL da API ───────────────────────
        // O ApiEndpointResolver lê o launchSettings.json do SenacGames.API
        // automaticamente. Nenhuma porta está hardcoded no código.
        System.Diagnostics.Debug.WriteLine("═══════════════════════════════════════");
        System.Diagnostics.Debug.WriteLine("  SenacGames Desktop — Inicializando");
        System.Diagnostics.Debug.WriteLine("═══════════════════════════════════════");

        var resolvedUrl = ApiEndpointResolver.Resolve();

        if (resolvedUrl == null)
        {
            // URL não encontrada — exibe mensagem amigável e encerra
            MessageBox.Show(
                "❌ Não foi possível localizar a URL da API SenacGames.\n\n" +
                "O sistema tentou encontrar automaticamente o arquivo:\n" +
                "  SenacGames.API/Properties/launchSettings.json\n\n" +
                "E também verificou o arquivo:\n" +
                "  SenacGames.Desktop/appsettings.json → ApiSettings.BaseUrl\n\n" +
                "Como resolver:\n" +
                "  1. Verifique se o projeto SenacGames.API existe na solução\n" +
                "  2. Ou configure manualmente em appsettings.json:\n" +
                "     \"ApiSettings\": { \"BaseUrl\": \"http://localhost:5223\" }\n\n" +
                "Consulte o README_DESKTOP.md para mais informações.",
                "Configuração da API não encontrada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            return; // Encerra a aplicação
        }

        System.Diagnostics.Debug.WriteLine($"  URL da API: {resolvedUrl}");
        System.Diagnostics.Debug.WriteLine("═══════════════════════════════════════");

        // ── PASSO 2: Verificação de disponibilidade (não-bloqueante) ──────────
        // Verifica se a API está rodando antes de abrir o Login.
        // Não impede o uso do app — apenas avisa o usuário.
        CheckApiAvailabilityAsync();

        // ── PASSO 3: Abre o formulário de Login ───────────────────────────────
        // O Login redirecionará para o MainForm após autenticação bem-sucedida
        Application.Run(new Forms.LoginForm());
    }

    /// <summary>
    /// Verifica a disponibilidade da API em background (fire and forget).
    /// Exibe aviso amigável se a API não estiver disponível,
    /// mas NÃO impede a abertura do LoginForm.
    ///
    /// Timeout: 5 segundos (configurado no PingApiAsync).
    /// </summary>
    private static async void CheckApiAvailabilityAsync()
    {
        try
        {
            var (isAvailable, errorMessage) =
                await HttpClientHelper.Instance.PingApiAsync();

            if (!isAvailable)
            {
                // Garante execução na thread da UI
                Application.OpenForms[0]?.Invoke(() =>
                {
                    MessageBox.Show(
                        $"⚠ A API SenacGames não está respondendo.\n\n" +
                        $"{errorMessage}\n\n" +
                        $"Você pode:\n" +
                        $"  1. Iniciar o projeto SenacGames.API no Visual Studio\n" +
                        $"  2. Aguardar a API inicializar e tentar fazer login\n\n" +
                        $"O aplicativo permanecerá aberto.",
                        "API Indisponível",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                });
            }
            else
            {
                System.Diagnostics.Debug.WriteLine(
                    "[Program] ✅ API disponível e respondendo.");
            }
        }
        catch (Exception ex)
        {
            // Log silencioso — não interrompe o fluxo principal
            System.Diagnostics.Debug.WriteLine(
                $"[Program] Aviso ao verificar API: {ex.Message}");
        }
    }
}