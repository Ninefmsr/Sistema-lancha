using System.ComponentModel.DataAnnotations;

namespace PierBoatApp.Presentation.Models.Account
{
    public class AccountLoginViewModel
    {
        [EmailAddress(ErrorMessage = "Por favor, informe um email válido.")]
        [Required(ErrorMessage = "Por favor, informe o seu email de acesso.")]
        public string? Email { get; set; }
        [MinLength(8, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe a sua senha de acesso.")]
        public string? Senha { get; set; }
    }
}
