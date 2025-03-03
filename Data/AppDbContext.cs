using Microsoft.EntityFrameworkCore;
using EncuestadorWeb.Models;

namespace EncuestadorWeb.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<EncuestaRespuesta> EncuestaRespuestas { get; set; }
    }
}