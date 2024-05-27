using System.ComponentModel.DataAnnotations;

namespace Gym.Modelos
{
    public class Clase
    {
        public int Id  { get; set; }
        [Required(ErrorMessage ="El nombre de la clase es obligatorio.")]
        [StringLength(50, ErrorMessage ="Maximo 50 caracteres")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "La descripcion de la clase es obligatorio.")]
        [StringLength(100, ErrorMessage = "Maximo 50 caracteres")]
        public string? Descripcion { get; set; }
        [Required(ErrorMessage = "La capacidad maxima es requerida.")]
        public int Capacidad { get; set; }
        virtual public ICollection<Persona>? Personas { get; set; }
    }
}
