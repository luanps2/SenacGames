// =============================================================================
// SenacGames.Desktop - DTOs/UsuarioDtos.cs
// =============================================================================
//  CONCEITO: DTOs de Usuários do Desktop
//
// Para gerenciar usuários do Identity via API, precisamos de DTOs
// que representem as operações de CRUD de usuários.
//
// NOTA: Os endpoints de usuário precisam ser adicionados à API
// (UsersController) para que o Desktop possa consumi-los.
// =============================================================================

namespace SenacGames.Desktop.DTOs
{
    /// <summary>
    /// DTO para representar um Usuário retornado pela API.
    /// </summary>
    public class UsuarioResponseDto
    {
        public string Id { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;

        /// <summary>Lista de roles (perfis) do usuário</summary>
        public List<string> Roles { get; set; } = new();

        /// <summary>
        /// Retorna o perfil principal do usuário como string formatada.
        /// Útil para exibição no DataGridView.
        /// </summary>
        public string PerfilPrincipal =>
            Roles.Contains("Admin") ? "Administrador" :
            Roles.Count > 0 ? string.Join(", ", Roles) : "Usuário Comum";
    }

    /// <summary>
    /// DTO para criação de um novo Usuário.
    /// </summary>
    public class CreateUsuarioDto
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string ConfirmPassword { get; set; } = string.Empty;
        public string Role { get; set; } = "User";
    }

    /// <summary>
    /// DTO para redefinição de senha de um usuário.
    /// </summary>
    public class ResetPasswordDto
    {
        public string UserId { get; set; } = string.Empty;
        public string NewPassword { get; set; } = string.Empty;
        public string ConfirmPassword { get; set; } = string.Empty;
    }

    /// <summary>
    /// DTO para atribuição/remoção de role (perfil) a um usuário.
    /// </summary>
    public class AssignRoleDto
    {
        public string UserId { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
    }
}
