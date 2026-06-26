# 🗺️ DesktopRoadmap — SenacGames.Desktop

> Guia passo a passo para construir uma aplicação Windows Forms moderna
> que consome uma API REST com ASP.NET Core Identity.

---

## 📋 Sumário

1. [Criação do Projeto Windows Forms](#1-criação-do-projeto)
2. [Instalação do Guna.UI2](#2-instalação-do-gunaui2)
3. [Configuração do HttpClient](#3-configuração-do-httpclient)
4. [Autenticação via API](#4-autenticação-via-api)
5. [Controle de Permissões](#5-controle-de-permissões)
6. [Criação dos UserControls](#6-criação-dos-usercontrols)
7. [Navegação entre Módulos](#7-navegação-entre-módulos)
8. [CRUDs com DataGridView](#8-cruds-com-datagridview)
9. [Dashboard com Cards](#9-dashboard-com-cards)
10. [Consumo da API (Serviços)](#10-consumo-da-api-serviços)
11. [Descoberta Automática da URL da API](#11-descoberta-automática-da-url-da-api-apiconfigurationservice) 🆕

---

## 1. Criação do Projeto

### Conceito
Um projeto Windows Forms em .NET 8 é criado com o template `winforms`.
O arquivo `.csproj` deve conter `<UseWindowsForms>true</UseWindowsForms>`.

### Comandos

```bash
# Cria o projeto na pasta SenacGames.Desktop
dotnet new winforms -n SenacGames.Desktop --framework net8.0 -o SenacGames.Desktop

# Adiciona à solução existente
dotnet sln SenacGames.slnx add SenacGames.Desktop/SenacGames.Desktop.csproj
```

### Estrutura mínima do `.csproj`

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>WinExe</OutputType>
    <TargetFramework>net8.0-windows</TargetFramework>
    <UseWindowsForms>true</UseWindowsForms>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
  </PropertyGroup>
</Project>
```

> 📌 **`net8.0-windows`** — O sufixo `-windows` é necessário para Windows Forms.

---

## 2. Instalação do Guna.UI2

### O que é o Guna.UI2?

Guna.UI2.WinForms é uma biblioteca de componentes visuais premium para Windows Forms.
Oferece: botões animados, painéis arredondados, caixas de texto modernas, etc.

### Instalação

```bash
# Package Manager Console (Visual Studio)
Install-Package Guna.UI2.WinForms

# PowerShell / Terminal
dotnet add package Guna.UI2.WinForms

# CMD
dotnet add package Guna.UI2.WinForms
```

### Componentes principais utilizados

| Componente | Uso |
|------------|-----|
| `Guna2TextBox` | Campos de texto com bordas arredondadas e placeholder |
| `Guna2Button` | Botões com animação de hover e bordas arredondadas |
| `Guna2Panel` | Painéis com sombra e bordas arredondadas (cards) |

### Exemplo de uso

```csharp
using Guna.UI2.WinForms;

var txtEmail = new Guna2TextBox
{
    PlaceholderText = "seu@email.com",
    Size = new Size(300, 40),
    BorderRadius = 8,
    FillColor = Color.WhiteSmoke,
    BorderColor = Color.LightGray
};
```

---

## 3. Configuração do HttpClient

### Conceito
`HttpClient` é a classe do .NET para fazer requisições HTTP (GET, POST, PUT, DELETE).

**Regras importantes:**
- ✅ Use **uma única instância** (Singleton) — evita esgotamento de sockets
- ✅ Use **CookieContainer** para manter sessão com Cookie Authentication
- ❌ Não crie `new HttpClient()` a cada requisição

### Implementação (Singleton com CookieContainer)

```csharp
// Helpers/HttpClientHelper.cs

using System.Net;

public sealed class HttpClientHelper
{
    // Instância única (Lazy = inicializada apenas quando necessária)
    private static readonly Lazy<HttpClientHelper> _instance =
        new(() => new HttpClientHelper());

    public static HttpClientHelper Instance => _instance.Value;

    private readonly CookieContainer _cookieContainer;
    private readonly HttpClient _client;

    private HttpClientHelper()
    {
        _cookieContainer = new CookieContainer();

        var handler = new HttpClientHandler
        {
            CookieContainer = _cookieContainer,
            UseCookies = true,
            AllowAutoRedirect = false,
            // Aceita certificados SSL em desenvolvimento:
            ServerCertificateCustomValidationCallback =
                HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
        };

        _client = new HttpClient(handler)
        {
            BaseAddress = new Uri("https://localhost:7000"),
            Timeout = TimeSpan.FromSeconds(30)
        };
    }

    // Método GET
    public async Task<T?> GetAsync<T>(string endpoint)
    {
        var response = await _client.GetAsync(endpoint);
        if (response.IsSuccessStatusCode)
            return await response.Content.ReadFromJsonAsync<T>();
        return default;
    }
}
```

---

## 4. Autenticação via API

### Conceito
A API usa **Cookie Authentication** do ASP.NET Core Identity.

Fluxo:
1. Desktop envia `POST /api/auth/login` com email e senha (JSON)
2. API valida credenciais e retorna um **cookie de sessão** + dados do usuário
3. `CookieContainer` armazena o cookie automaticamente
4. Próximas requisições enviam o cookie no header `Cookie:`
5. API autentica automaticamente o usuário pelo cookie

### Estrutura do Login

```csharp
// Services/AuthApiService.cs

public async Task<(bool Success, UserResponseDto? User, string Error)>
    LoginAsync(string email, string password)
{
    var dto = new LoginRequestDto { Email = email, Password = password };

    // POST /api/auth/login
    var (success, data, error) = await _http.PostAsync<UserResponseDto>(
        "/api/auth/login", dto);

    return (success, data, error);
}
```

### LoginForm — Fluxo completo

```csharp
// Forms/LoginForm.cs

private async void BtnEntrar_Click(object? sender, EventArgs e)
{
    var (success, user, error) = await _authService.LoginAsync(
        txtEmail.Text, txtSenha.Text);

    if (success && user != null)
    {
        // 1. Armazena na sessão
        SessionManager.Instance.SetUser(user);

        // 2. Esconde o Login
        this.Hide();

        // 3. Abre o MainForm
        using var mainForm = new MainForm();
        mainForm.ShowDialog();

        // 4. Fecha ao retornar
        this.Close();
    }
    else
    {
        lblErro.Text = error; // Exibe mensagem de erro
    }
}
```

---

## 5. Controle de Permissões

### Conceito
O controle de acesso é feito em duas camadas:

1. **API**: verifica o cookie e a role do usuário (`[Authorize(Roles = "Admin")]`)
2. **Desktop**: oculta/mostra botões baseado no perfil (só UX, a API valida de verdade)

### SessionManager (Singleton)

```csharp
// Helpers/SessionManager.cs

public sealed class SessionManager
{
    public static SessionManager Instance { get; } = new();
    public UserResponseDto? CurrentUser { get; private set; }
    public bool IsAdmin => CurrentUser?.Roles.Contains("Admin") ?? false;

    public void SetUser(UserResponseDto user) => CurrentUser = user;
    public void Clear() => CurrentUser = null;
}
```

### Aplicando no MainForm

```csharp
// Forms/MainForm.cs

private void ConfigurarPermissoes()
{
    bool isAdmin = SessionManager.Instance.IsAdmin;

    // Oculta módulos exclusivos para Admin
    btnCategorias.Visible = isAdmin;
    btnUsuarios.Visible = isAdmin;
}
```

### Aplicando em UserControls

```csharp
// UserControls/GamesUserControl.cs

private void ConfigurarPermissoes()
{
    bool isAdmin = SessionManager.Instance.IsAdmin;

    // Usuário comum: não pode criar/editar/excluir
    btnNovo.Visible = isAdmin;
    btnEditar.Visible = isAdmin;
    btnExcluir.Visible = isAdmin;
}
```

---

## 6. Criação dos UserControls

### Conceito
Um `UserControl` é um controle reutilizável que encapsula layout e lógica.
No MainForm, cada "página" é um UserControl carregado dinamicamente.

### Estrutura básica

```csharp
// UserControls/MeuModuloUserControl.cs

namespace SenacGames.Desktop.UserControls
{
    public class MeuModuloUserControl : UserControl
    {
        public MeuModuloUserControl()
        {
            InitializeComponent();
            this.Load += async (s, e) => await CarregarDadosAsync();
        }

        private void InitializeComponent()
        {
            this.BackColor = SenacTheme.CinzaFundo;
            // Adiciona controles aqui...
        }

        private async Task CarregarDadosAsync()
        {
            // Chama a API e popula os controles
        }
    }
}
```

---

## 7. Navegação entre Módulos

### Conceito
Em vez de MDI (Multiple Document Interface), usamos o padrão moderno:
- **Sidebar**: botões de navegação
- **PainelConteudo**: recebe UserControls dinamicamente

### Implementação

```csharp
// Forms/MainForm.cs

private UserControl? _controlAtual;

/// <summary>Carrega um UserControl no painel principal</summary>
private void Navegar(UserControl control, Guna2Button? botao = null)
{
    // Remove o controle anterior
    if (_controlAtual != null)
    {
        pnlConteudo.Controls.Remove(_controlAtual);
        _controlAtual.Dispose();
    }

    // Adiciona o novo controle
    control.Dock = DockStyle.Fill;
    pnlConteudo.Controls.Add(control);
    _controlAtual = control;

    // Destaca o botão ativo na sidebar
    AtualizarBotaoAtivo(botao);
}

// Uso (no clique de um botão da sidebar):
btnGames.Click += (s, e) => Navegar(new GamesUserControl(), btnGames);
```

---

## 8. CRUDs com DataGridView

### Conceito
`DataGridView` é o componente nativo do Windows Forms para exibir tabelas.
O SenacTheme centraliza o estilo para evitar repetição de código.

### Configuração básica

```csharp
// Themes/SenacTheme.cs

public static void AplicarEstiloGrid(DataGridView grid)
{
    grid.BackgroundColor = CinzaFundo;
    grid.BorderStyle = BorderStyle.None;
    grid.ColumnHeadersDefaultCellStyle.BackColor = AzulPrimario;
    grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
    grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    grid.ReadOnly = true;
    grid.AllowUserToAddRows = false;
    // ...
}
```

### CRUD completo via API

```csharp
// Listar (GET)
var games = await _gamesService.GetAllAsync();
foreach (var g in games)
    gridGames.Rows.Add(g.Id, g.Title, g.CategoryName, g.ReleaseYear);

// Criar (POST)
var dto = new CreateGameDto { Title = "Novo Game", CategoryId = 1 };
var (success, game, error) = await _gamesService.CreateAsync(dto);

// Editar (PUT)
var updateDto = new UpdateGameDto { Title = "Game Editado" };
await _gamesService.UpdateAsync(id, updateDto);

// Excluir (DELETE)
await _gamesService.DeleteAsync(id);
```

---

## 9. Dashboard com Cards

### Conceito
Cards são painéis visuais que exibem uma métrica de forma destacada.
Usamos `Guna2Panel` com sombra e borda colorida no topo.

### Criação de um card

```csharp
private Guna2Panel CriarCard(string titulo, string numero, Color cor, Point local)
{
    var card = new Guna2Panel
    {
        Size = new Size(200, 120),
        Location = local,
        FillColor = Color.White,
        BorderRadius = 12,
        ShadowDecoration = { Enabled = true, Depth = 12 }
    };

    // Barra colorida no topo
    var barra = new Panel { BackColor = cor, Dock = DockStyle.Top, Height = 4 };

    // Número grande
    var lblNumero = new Label
    {
        Text = numero,
        Font = new Font("Segoe UI", 24f, FontStyle.Bold),
        Location = new Point(14, 40)
    };

    card.Controls.AddRange(new Control[] { barra, lblNumero });
    return card;
}
```

---

## 10. Consumo da API (Serviços)

### Padrão de Service

Cada módulo tem seu próprio Service que:
- Conhece apenas os endpoints do módulo
- Usa o `HttpClientHelper.Instance` compartilhado
- Retorna DTOs tipados (não JSON raw)

```csharp
// Services/GamesApiService.cs

public class GamesApiService
{
    private readonly HttpClientHelper _http = HttpClientHelper.Instance;

    public async Task<List<GameResponseDto>> GetAllAsync()
    {
        var games = await _http.GetAsync<List<GameResponseDto>>("/api/games");
        return games ?? new();
    }

    public async Task<(bool, GameResponseDto?, string)> CreateAsync(CreateGameDto dto)
        => await _http.PostAsync<GameResponseDto>("/api/games", dto);

    public async Task<(bool, GameResponseDto?, string)> UpdateAsync(int id, UpdateGameDto dto)
        => await _http.PutAsync<GameResponseDto>($"/api/games/{id}", dto);

    public async Task<(bool, string)> DeleteAsync(int id)
        => await _http.DeleteAsync($"/api/games/{id}");
}
```

### Tratamento de erros

```csharp
try
{
    var games = await _gamesService.GetAllAsync();
    PopularGrid(games);
}
catch (HttpRequestException)
{
    MessageBox.Show("Não foi possível conectar à API.", "Erro",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
}
catch (Exception ex)
{
    MessageBox.Show($"Erro inesperado: {ex.Message}", "Erro",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
}
```

---

## 🏁 Ordem de Desenvolvimento Recomendada

Para alunos que queiram construir o projeto do zero:

1. ✅ Crie o projeto Windows Forms
2. ✅ Instale o Guna.UI2
3. ✅ Crie o `AppConfig.cs` e `appsettings.json`
4. ✅ Crie o `HttpClientHelper.cs`
5. ✅ Crie o `SessionManager.cs`
6. ✅ Crie o `SenacTheme.cs`
7. ✅ Crie os DTOs
8. ✅ Crie os Services (`AuthApiService`, `GamesApiService`, etc.)
9. ✅ Crie o `LoginForm`
10. ✅ Crie o `MainForm` com sidebar
11. ✅ Crie os `UserControls` (Dashboard, Games, Categorias, Usuários, Perfil)
12. ✅ Crie os `Dialogs` (GameFormDialog, UsuarioFormDialog)
13. ✅ Implemente a descoberta automática de URL (`ApiEndpointResolver`)
14. ✅ Teste com a API em execução

---

## 11. Descoberta Automática da URL da API (ApiConfigurationService)

### Por que não usar URLs hardcoded?

URLs e portas fixas no código causam problemas reais:

| Problema | Impacto |
|---|---|
| Visual Studio muda a porta a cada run | Desktop não conecta sem reconfigurar |
| Desenvolvedor novo clona o projeto | Precisa descobrir a porta manualmente |
| Muda de desenvolvimento para produção | Precisa recompilar para trocar a URL |
| CI/CD ou ambiente de testes | Porta diferente, integração quebra |

**Regra de ouro:** *Nunca coloque porta ou URL no código. Sempre leia de configuração.*

---

### Como o Desktop encontra automaticamente a API

O **`ApiEndpointResolver`** implementa uma estratégia de resolução em cascata:

```
Program.Main()
      │
      ▼
ApiEndpointResolver.Resolve()
      │
      ├── PASSO 1: Localizar launchSettings.json
      │        │
      │        ├─ bin\Debug\net8.0-windows\                       (executável)
      │        ├─ bin\Debug\net8.0-windows\..\..\..\..\           (sobe 4 níveis)
      │        └─ SenacGames.API\Properties\launchSettings.json   (arquivo alvo)
      │
      ├── PASSO 2: Parsear o JSON
      │        │
      │        └─ profiles → "http" → applicationUrl → "http://localhost:5223"
      │
      ├── PASSO 3 (fallback): Ler appsettings.json
      │        │
      │        └─ ApiSettings.BaseUrl → "http://localhost:5223"
      │
      └── PASSO 4 (falha): retorna null → MessageBox amigável
```

---

### Funcionamento do ApiEndpointResolver

```csharp
// Helpers/ApiEndpointResolver.cs
public static class ApiEndpointResolver
{
    // Singleton com cache — resolve apenas uma vez por sessão
    public static string? Resolve() { ... }

    // Forcça re-resolução (útil em testes)
    public static void Reset() { ... }

    // Prioridade 1: lê launchSettings.json do projeto API
    private static string? TryResolveFromLaunchSettings() { ... }

    // Prioridade 2: lê appsettings.json do Desktop
    private static string? TryResolveFromAppSettings() { ... }
}
```

**Preferência de perfil no launchSettings:**
- `"http"` → sem SSL → mais simples para desenvolvimento
- `"https"` → com SSL → aceito como fallback
- `"IIS Express"` → aceito como última opção

---

### Fluxo de inicialização da comunicação

```
Program.Main()
      │
      ▼
ApiEndpointResolver.Resolve()    ←─ PASSO 1: Descoberta da URL
      │
      ├── null? → MessageBox de erro → encerra o app
      │
      └── URL encontrada?
              │
              ▼
AppConfig.ApiBaseUrl             ←─ PASSO 2: Exposição para o app
      = ApiEndpointResolver.Resolve()
              │
              ▼
HttpClientHelper (Singleton)     ←─ PASSO 3: HttpClient configurado
      BaseAddress = AppConfig.ApiBaseUrl
              │
              ▼
HttpClientHelper.PingApiAsync()  ←─ PASSO 4: Verificação (não-bloqueante)
              │
              ├── offline? → aviso amigável (app continua)
              │
              └── online? → abre LoginForm
```

---

### Escalabilidade — Como trocar a API de localhost para produção

A solução é totalmente escalável. Para usar em produção:

**Opção 1: appsettings.json** (mais simples)
```json
{
  "ApiSettings": {
    "BaseUrl": "https://api.senacgames.com"
  }
}
```

**Opção 2: Variável de ambiente** (CI/CD)
```bash
# O resolver já lê SolutionDir de variáveis de ambiente
export SolutionDir=/path/to/solution
```

Em nenhum caso é necessário modificar código-fonte.

---

### Tratamento de erros de comunicação

O `HttpClientHelper` categoriza erros em mensagens claras:

| Tipo de erro | Mensagem exibida |
|---|---|
| Conexão recusada | A API não está em execução |
| Timeout | A requisição excedeu o tempo limite |
| SSL/certificado | Erro de conexão SSL — tente HTTP |
| DNS / host não encontrado | Host não encontrado — verifique a URL |
| URL inválida | URL da API inválida — verifique appsettings |
| Genérico | Mensagem original com contexto |

---

*SenacGames Desktop Roadmap — Guia educacional SENAC-SP*
