using Microsoft.EntityFrameworkCore;

namespace Gym.Modelos
{
    public class GymDBContext : DbContext
    {
        public GymDBContext(DbContextOptions<GymDBContext> options)  : base(options)
        { 
        }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Clasificacion> Clasificaciones { get; set; }
    }
}
