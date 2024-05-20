namespace Gym.Modelos
{
    public class Clasificacion
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        //Navegacion EF
        virtual public ICollection<Persona>? Personas { get; set; }
    }
}
