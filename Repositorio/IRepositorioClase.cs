using Gym.Modelos;

namespace Gym.Repositorio
{
    public interface IRepositorioClase
    {
        Task<List<Clase>> GetAll();
        Task<Clase?> Get(int id);
        Task<Clase> Add(Clase clase);
        Task Update(int id, Clase clase);
        Task Delete(int id);
    }
}

