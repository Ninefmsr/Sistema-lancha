using System.ComponentModel.DataAnnotations;

namespace PierBoatApp.Presentation.Models.Lancha
{
    public class CadastrarViewModel
    {
        

        [Required(ErrorMessage = "Por favor, informe o nome")]
        [MinLength(8, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe a data da conta.")]
        public DateTime? Data { get; set; }

        [Required(ErrorMessage = "Por favor, informe um telefone")]
        [MinLength(10, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        public string? Telefone {  get; set; }

        [Required(ErrorMessage = "Por favor, informe o periodo desejado.")]
        public int? Periodo { get; set; }

        [Required(ErrorMessage = "Por favor, informe uma observação")]
        [MinLength(4, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        public string? Observacao {  get; set; }
    }
}
