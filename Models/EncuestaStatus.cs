using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace EncuestadorWeb.Models
{

  public class EncuestaStatus
  {
    public int Id { get; set; }
    public int IdUsuario { get; set; }
    public int IdEncuestaAsig { get; set; }
    public bool StatusEncuesta { get; set; }
  }
}