# 🖥️ README — SenacGames.Desktop

> Cliente administrativo Windows Forms para o sistema SenacGames.
> Consome exclusivamente a API REST já existente.

---

## 📐 Arquitetura

```
SenacGames.Desktop (Windows Forms)
        │
        ▼  HTTP (HttpClient + CookieContainer)
SenacGames.API (ASP.NET Core)
        │
        ▼
SenacGames.Application (Services + DTOs)
        │
        ▼
SenacGames.Infrastructure (EF Core + Identity)
        │
        ▼
Banco de Dados (SQL Server LocalDB)
```

O Desktop **nunca** acessa o banco diretamente.
Toda comunicação ocorre via endpoints REST da API.

---

## 📦 Dependências

| Pacote | Versão | Uso |
|--------|--------|-----|
| `Guna.UI2.WinForms` | 2.0.4.8 | Componentes visuais modernos |
| `net8.0-windows` | .NET 8 | Target framework |

---

## 🗂️ Estrutura do Projeto

```
SenacGames.Desktop/
├── Forms/
│   ├── LoginForm.cs           → Tela de login
│   ├── MainForm.cs            → Shell principal (sidebar + navegação)
│   ├── GameFormDialog.cs      → Dialog: criar/editar game
│   └── UsuarioFormDialog.cs   → Dialog: criar usuário
│
├── UserControls/
│   ├── DashboardUserControl.cs   → Cards de métricas + últimos games
│   ├── GamesUserControl.cs       → CRUD de games
│   ├── CategoriasUserControl.cs  → CRUD de categorias
│   ├── UsuariosUserControl.cs    → Gerenciamento de usuários
│   └── PerfilUserControl.cs      → Perfil do usuário logado
│
├── Services/
│   ├── AuthApiService.cs        → Endpoints: /api/auth/*
│   ├── GamesApiService.cs       → Endpoints: /api/games/*
│   ├── CategoriasApiService.cs  → Endpoints: /api/categories/*
│   └── UsuariosApiService.cs    → Endpoints: /api/users/*
│
├── DTOs/
│   ├── AuthDtos.cs       → LoginRequestDto, UserResponseDto
│   ├── GameDtos.cs       → GameResponseDto, CreateGameDto, UpdateGameDto
│   ├── CategoriaDtos.cs  → CategoriaResponseDto, CreateCategoriaDto
│   └── UsuarioDtos.cs    → UsuarioResponseDto, CreateUsuarioDto
│
├── Helpers/
│   ├── ApiEndpointResolver.cs → Descoberta automática da URL da API ⭐
│   ├── HttpClientHelper.cs    → HttpClient singleton com CookieContainer
│   ├── SessionManager.cs      → Singleton: dados do usuário logado
│   └── AppConfig.cs           → Configurações gerais (usa o Resolver para URL)
│
├── Themes/
│   └── SenacTheme.cs  → Design system: cores, fontes, dimensões
│
├── appsettings.json           → URL da API e configurações
├── Program.cs                 → Ponto de entrada
└── SenacGames.Desktop.csproj  → Configuração do projeto
```

---

## ⚙️ Configuração

### 1. Requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio 2022+ ou VS Code
- API `SenacGames.API` em execução

### 2. 🤖 Descoberta automática da URL da API

> **Não é necessário configurar nada durante o desenvolvimento!**

O Desktop localiza automaticamente a URL da API em ordem de prioridade:

```
╔══════════════════════════════════════════════════════════╗
║  PRIORIDADE 1 — launchSettings.json do SenacGames.API    ║
║  ─────────────────────────────────────────────────────── ║
║  Lê automaticamente:                                     ║
║    SenacGames.API/Properties/launchSettings.json         ║
║  Extrai o perfil "http" → applicationUrl                 ║
║  → Funciona mesmo que o VS mude a porta!                 ║
╠══════════════════════════════════════════════════════════╣
║  PRIORIDADE 2 — appsettings.json do Desktop              ║
║  ─────────────────────────────────────────────────────── ║
║  Lê: ApiSettings.BaseUrl                                 ║
║  → Fallback configurável sem recompilar                  ║
╠══════════════════════════════════════════════════════════╣
║  PRIORIDADE 3 — URL não encontrada                       ║
║  ─────────────────────────────────────────────────────── ║
║  Exibe mensagem amigável e encerra o app                 ║
║  → Nunca lança exceção sem tratamento                    ║
╚══════════════════════════════════════════════════════════╝
```

A classe responsável é o **`ApiEndpointResolver`** em `Helpers/ApiEndpointResolver.cs`.

#### Como funciona a localização do launchSettings.json

O executável roda em `bin\Debug\net8.0-windows\`. O resolver sobe automaticamente
4 níveis para encontrar a raiz da solução e então localiza:
```
SenacGames.API/Properties/launchSettings.json
```

#### Diagnóstico no Output do Visual Studio

Abra **View → Output → Debug** para ver o log da descoberta:
```
[ApiEndpointResolver] 🔍 Testando: ...\SenacGames.API\Properties\launchSettings.json
[ApiEndpointResolver] 📄 launchSettings.json encontrado em: ...
[ApiEndpointResolver] ✓ Perfil 'http' → applicationUrl: http://localhost:5223
[ApiEndpointResolver] ✅ API localizada em: http://localhost:5223
[ApiEndpointResolver]    Origem: launchSettings.json do SenacGames.API
```

### 3. Alterar a URL manualmente (opcional)

Só necessário se o `launchSettings.json` não for encontrado (ex: produção).

Edite `SenacGames.Desktop/appsettings.json`:

```json
{
  "ApiSettings": {
    "BaseUrl": "http://localhost:5223"
  }
}
```

#### Em produção

```json
{
  "ApiSettings": {
    "BaseUrl": "https://api.senacgames.com"
  }
}
```

Em produção, o `launchSettings.json` não existe. O resolver automaticamente
usa o `appsettings.json`.

### 4. Instalar dependências

```bash
# Package Manager Console (Visual Studio)
Install-Package Guna.UI2.WinForms

# PowerShell / Terminal
dotnet add package Guna.UI2.WinForms

# CMD
dotnet add package Guna.UI2.WinForms
```

---

## 🚀 Execução

### Passo 1 — Iniciar a API

```bash
cd SenacGames.API
dotnet run
```

### Passo 2 — Iniciar o Desktop

```bash
cd SenacGames.Desktop
dotnet run
```

Ou no Visual Studio: **defina SenacGames.Desktop como projeto de inicialização** e pressione F5.

> ⚠️ **A API deve estar em execução ANTES de abrir o Desktop.**

---

## 🔑 Autenticação

A API usa **Cookie Authentication** (ASP.NET Core Identity).

- O Desktop envia credenciais via `POST /api/auth/login`
- A API valida e retorna um cookie de sessão
- O `HttpClientHelper` armazena o cookie automaticamente
- Todas as requisições subsequentes enviam o cookie para a API
- No logout: `POST /api/auth/logout` + limpeza local dos cookies

**Usuários padrão** (criados pelo SeedData da API):

| E-mail | Senha | Perfil |
|--------|-------|--------|
| `admin@senac.br` | `Admin@123` | Administrador |
| `usuario@senac.br` | `User@123` | Usuário Comum |

> Verifique os usuários reais no `SeedData.cs` da API.

---

## 👥 Controle de Perfis

| Módulo | Admin | Usuário Comum |
|--------|-------|---------------|
| Dashboard | ✅ | ✅ |
| Games (CRUD completo) | ✅ | 👁️ Somente leitura |
| Categorias | ✅ | ❌ |
| Usuários | ✅ | ❌ |
| Perfil | ✅ | ✅ |

---

## 🎨 Identidade Visual

| Elemento | Cor | Hex |
|----------|-----|-----|
| Azul primário | Senac Azul | `#004B87` |
| Azul variante | Links/hover | `#0066CC` |
| Laranja primário | Destaques | `#FF6600` |
| Branco | Fundos | `#FFFFFF` |
| Cinza fundo | Background | `#F5F7FA` |
| Grafite | Texto | `#333D4B` |

---

## 📡 Endpoints Consumidos

| Método | Endpoint | Descrição |
|--------|----------|-----------|
| POST | `/api/auth/login` | Login com cookie |
| POST | `/api/auth/logout` | Logout |
| GET | `/api/auth/me` | Dados do usuário atual |
| GET | `/api/games` | Listar todos os games |
| GET | `/api/games/{id}` | Buscar game por ID |
| POST | `/api/games` | Criar game (Admin) |
| PUT | `/api/games/{id}` | Atualizar game (Admin) |
| DELETE | `/api/games/{id}` | Excluir game (Admin) |
| GET | `/api/categories` | Listar categorias |
| POST | `/api/categories` | Criar categoria (Admin) |
| PUT | `/api/categories/{id}` | Atualizar categoria (Admin) |
| DELETE | `/api/categories/{id}` | Excluir categoria (Admin) |

---

## 🔧 Build

```bash
# Compilar o projeto Desktop
dotnet build SenacGames.Desktop/SenacGames.Desktop.csproj

# Compilar toda a solução
dotnet build SenacGames.slnx
```

---

## 📚 Tecnologias

- **.NET 8** — Framework base
- **Windows Forms** — Framework de interface desktop
- **Guna.UI2.WinForms** — Componentes visuais modernos
- **System.Text.Json** — Serialização JSON
- **ASP.NET Core Identity** — Autenticação (gerenciada pela API)
- **HttpClient + CookieContainer** — Comunicação HTTP com sessão

---

*SenacGames Desktop — Projeto educacional SENAC-SP*
