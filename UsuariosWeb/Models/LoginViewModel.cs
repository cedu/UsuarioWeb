using System.ComponentModel.DataAnnotations;

namespace UsuariosWeb.Models
{
    /// <summary>
    /// Modelo de dados para a requisição de autenticação de usuários
    /// </summary>
    public class LoginViewModel
    {
        [EmailAddress(ErrorMessage = "Por favor, informe um endereço de email válido.")]
        [Required(ErrorMessage = "Por favor, informe o email de acesso.")]
        public string? Email { get; set; }

        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^a-zA-Z0-9\s]).{8,}$", 
            ErrorMessage = "Por favor, informe a senha com letras minúsculas, maiúsculas, números, símbolos e pelo menos 8 caracteres.")]
        [Required(ErrorMessage = "Por favor, informe a senha de acesso.")]
        public string? Senha { get; set; }
    }
}
