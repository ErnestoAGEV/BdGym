using Gym.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Gym.Repositorio
{
    public class RepositorioPersonas : IRepositorioPersonas
    {
        private readonly GymDBContext _context;

        public RepositorioPersonas(GymDBContext context)
        {
            _context = context;
        }

        public async Task<Persona> Add(Persona persona)
        {
            await _context.Personas.AddAsync(persona);
            await _context.SaveChangesAsync();
            return persona;
        }

        public async Task Delete(int id)
        {
            var persona = await _context.Personas.FindAsync(id);
            if (persona == null)
            {
                _context.Personas.Remove(persona);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Persona?> Get(int id)
        {
            return await _context.Personas.Include(h => h.Clases).Where(r=>r.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Persona>> GetAll()
        {
            return await _context.Personas.ToListAsync();
        }

        public async Task<List<Clasificacion>> GetClasificaciones()
        {
            return await _context.Clasificaciones.ToListAsync();
        }

        public async Task<List<Clase>> GetClases()
        {
            return await _context.Clases.ToListAsync();
        }

        public async Task Update(int id, Persona persona)
        {
            var personaactual = await _context.Personas.FindAsync(id);
            if (personaactual != null)
            {
                personaactual.Nombre = persona.Nombre;
                personaactual.Correo = persona.Correo;
                personaactual.Telefono = persona.Telefono;
                personaactual.Clases = persona.Clases;
                await _context.SaveChangesAsync();
            }
        }

    }
}
