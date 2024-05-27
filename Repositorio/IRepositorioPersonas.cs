using Gym.Modelos;

namespace Gym.Repositorio
{
    public interface IRepositorioPersonas
    {
        Task<List<Persona>> GetAll();
        Task<Persona?> Get(int id);
        Task<List<Clasificacion>> GetClasificaciones();
        Task<List<Clase>> GetClases();
        Task<Persona> Add(Persona persona);
        Task Update(int id, Persona persona);
        Task Delete(int id);
    }
}
