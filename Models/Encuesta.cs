using System.ComponentModel.DataAnnotations;
<<<<<<< HEAD
using Microsoft.EntityFrameworkCore;
=======
>>>>>>> 1d49a78 (Update Conteo Correcto del precio de las tazas y nuevo archivo para la validación de que las preguntas no vayan vacías)

namespace EncuestadorWeb.Models
{
    public class EncuestaRespuesta
    {
        public int Id { get; set; }
        public int IdEncuesta { get; set; }
        public int IdPregunta { get; set; }
        [Required(ErrorMessage = "Debes seleccionar una opciónaaa.")]
        public int IdRespuesta { get; set; }
        public int IdCalificacion { get; set; }
        public int IdUsuario { get; set; }
        public string Observaciones { get; set; } = string.Empty;
    }
}