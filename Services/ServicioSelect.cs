using EncuestadorWeb.Models;
using EncuestadorWeb.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EncuestadorWeb.Services
{
    public class EncuestaService
    {
        private readonly AppDbContext _context;

        public EncuestaService(AppDbContext context)
        {
            _context = context;
        }

        // Método para obtener todas las encuestas
        public async Task<List<EncuestaStatus>> ObtenerEncuestasAsync()
        {
            return await _context.EncuestasStatus.ToListAsync();
        }
    }
}