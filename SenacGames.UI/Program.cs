// =============================================================================
// SenacGames.UI - Program.cs
// =============================================================================
// 📌 CONCEITO: Este é o ponto de entrada da aplicação MVC (Web).
// Aqui configuramos o servidor web que serve as páginas HTML (Razor Views).
//
// A diferença para o Program.cs da API:
// - API: retorna JSON (dados) — AddControllers()
// - MVC: retorna HTML (páginas) — AddControllersWithViews()
// =============================================================================

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SenacGames.Application.Interfaces;
using SenacGames.Application.Services;
using SenacGames.Domain.Interfaces;
using SenacGames.Infrastructure.Context;
using SenacGames.Infrastructure.Identity;
using SenacGames.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// =====================================================================
// ENTITY FRAMEWORK CORE — Banco de dados
// =====================================================================
builder.Services.AddDbContext<SenacGamesDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// =====================================================================
// ASP.NET CORE IDENTITY — Autenticação
// =====================================================================
builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequiredLength = 6;
})
.AddEntityFrameworkStores<SenacGamesDbContext>()
.AddDefaultTokenProviders();

// Configuração dos cookies de autenticação
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";               // Redireciona para login
    options.LogoutPath = "/Account/Logout";              // Redireciona para logout
    options.AccessDeniedPath = "/Account/AccessDenied";  // Página de acesso negado
});

// =====================================================================
// DEPENDENCY INJECTION — Repositórios e Serviços
// =====================================================================
builder.Services.AddScoped<IGameRepository, GameRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IGameService, GameService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

// =====================================================================
// MVC — Adiciona suporte a Controllers + Views (Razor)
// =====================================================================
builder.Services.AddControllersWithViews();

var app = builder.Build();

// =====================================================================
// PIPELINE DE MIDDLEWARES
// =====================================================================
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // Serve arquivos estáticos (CSS, JS, imagens) de wwwroot

app.UseRouting();

app.UseAuthentication(); // 📌 IMPORTANTE: Sempre ANTES de UseAuthorization
app.UseAuthorization();

// =====================================================================
// ROTAS — Configuração de rotas MVC
// =====================================================================
// 📌 CONCEITO: Rota padrão do MVC
// {controller=Home}/{action=Index}/{id?}
// Significa: /NomeController/NomeAction/IdOpcional
// Exemplo: /Games/Details/5 → GamesController.Details(5)
// =====================================================================
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Seed Data — Popula o banco com dados iniciais
await SeedData.SeedAsync(app.Services);

app.Run();
