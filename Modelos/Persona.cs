using System.ComponentModel.DataAnnotations;

namespace Gym.Modelos
{
    public class Persona
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El correo es obligatorio")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        [EmailAddress(ErrorMessage = "Debe ser un correo valido")]
        public string? Correo { get; set; }
        [Required(ErrorMessage = "El telefono es obligatorio")]
        [StringLength(10, ErrorMessage = "Maximo 10 caracteres")]
        public string? Telefono { get; set; }

        //Propiedad de clasificación
        public int ClasificacionId { get; set; }
        virtual public Clasificacion? Clasificacion { get; set; }
        virtual public ICollection<Clase>? Clases { get; set; }

    }
}
