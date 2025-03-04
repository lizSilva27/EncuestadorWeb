using System.ComponentModel.DataAnnotations;

namespace EncuestadorWeb.Models
{
    public class EncuestaRespuesta
    {
        public int Id { get; set; }
        public int IdEncuesta { get; set; }
        public int IdPregunta { get; set; }
        [Required(ErrorMessage = "Debes seleccionar una opción.")]
        public int IdRespuesta { get; set; }
        public int IdCalificacion { get; set; }
        public int IdUsuario { get; set; }
        public string Observaciones { get; set; } = string.Empty;
    }
}