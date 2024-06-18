using System.ComponentModel.DataAnnotations;

namespace PierBoatApp.Presentation.Models.Lancha
{
    public class ConsultaViewModel
    {
        [Required(ErrorMessage = "Por favor, informe a data de início.")]
        public DateTime? DataInicio { get; set; }

        [Required(ErrorMessage = "Por favor, informe a data de término.")]
        public DateTime? DataFim { get; set; }
    }
}
