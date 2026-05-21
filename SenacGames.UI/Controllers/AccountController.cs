// =============================================================================
// SenacGames.UI - AccountController
// =============================================================================
// 📌 CONCEITO: Autenticação MVC
// Este controller gerencia Login, Logout e Registro de usuários.
// Utiliza o ASP.NET Core Identity para autenticação com cookies.
//
// FLUXO DE LOGIN:
// 1. Usuário acessa /Account/Login (GET)
// 2. Preenche email e senha no formulário
// 3. Envia o formulário (POST)
// 4. SignInManager verifica as credenciais
// 5. Se correto: cria cookie de autenticação e redireciona
// 6. Se errado: exibe mensagem de erro
// =============================================================================

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SenacGames.Application.DTOs;

namespace SenacGames.UI.Controllers
{
    /// <summary>
    /// Controller de autenticação — Login, Logout, Register.
    /// </summary>
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // =====================================================================
        // LOGIN
        // =====================================================================

        /// <summary>
        /// Exibe o formulário de login.
        /// GET /Account/Login
        /// </summary>
        [HttpGet]
        public IActionResult Login(string? returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        /// <summary>
        /// Processa o login do usuário.
        /// POST /Account/Login
        /// </summary>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginDto dto, string? returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            // Tenta fazer login
            var result = await _signInManager.PasswordSignInAsync(
                dto.Email, dto.Password, isPersistent: false, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                // Redireciona para a URL anterior ou para a Home
                if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    return Redirect(returnUrl);

                return RedirectToAction("Index", "Home");
            }

            // Se falhou, exibe mensagem de erro
            ModelState.AddModelError(string.Empty, "Email ou senha inválidos.");
            return View(dto);
        }

        // =====================================================================
        // REGISTER
        // =====================================================================

        /// <summary>
        /// Exibe o formulário de registro.
        /// GET /Account/Register
        /// </summary>
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        /// <summary>
        /// Processa o registro de novo usuário.
        /// POST /Account/Register
        /// </summary>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterDto dto)
        {
            if (dto.Password != dto.ConfirmPassword)
            {
                ModelState.AddModelError(string.Empty, "As senhas não coincidem.");
                return View(dto);
            }

            var user = new IdentityUser
            {
                UserName = dto.Email,
                Email = dto.Email
            };

            var result = await _userManager.CreateAsync(user, dto.Password);

            if (result.Succeeded)
            {
                // Faz login automático após o registro
                await _signInManager.SignInAsync(user, isPersistent: false);
                return RedirectToAction("Index", "Home");
            }

            // Se falhou, exibe os erros
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return View(dto);
        }

        // =====================================================================
        // LOGOUT
        // =====================================================================

        /// <summary>
        /// Faz logout do usuário.
        /// POST /Account/Logout
        /// </summary>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        // =====================================================================
        // ACCESS DENIED
        // =====================================================================

        /// <summary>
        /// Página de acesso negado.
        /// Exibida quando um usuário tenta acessar uma área sem permissão.
        /// </summary>
        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
