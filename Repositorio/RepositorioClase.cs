using Gym.Modelos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gym.Repositorio
{
    public class RepositorioClase : IRepositorioClase
    {
        private readonly GymDBContext _context;

        public RepositorioClase(GymDBContext context)
        {
            _context = context;
        }

        public async Task<Clase> Add(Clase clase)
        {
            await _context.Clases.AddAsync(clase);
            await _context.SaveChangesAsync();
            return clase;
        }

        public async Task Delete(int id)
        {
            var clase = await _context.Clases.FindAsync(id);
            if (clase != null)
            {
                _context.Clases.Remove(clase);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Clase?> Get(int id)
        {
            return await _context.Clases
                .Include(c => c.Personas)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<List<Clase>> GetAll()
        {
            return await _context.Clases.ToListAsync();
        }

        public async Task Update(int id, Clase clase)
        {
            var claseactual = await _context.Clases.FindAsync(id);
            if (claseactual != null)
            {
                claseactual.Descripcion = clase.Descripcion;
                claseactual.Nombre = clase.Nombre;
                claseactual.Capacidad = clase.Capacidad;
                await _context.SaveChangesAsync();
            }
        }
    }
}
