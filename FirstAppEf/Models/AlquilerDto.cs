using FirstAppEf.Repository.Entities;
using System.ComponentModel.DataAnnotations;

namespace FirstAppEf.Models
{
    public class AlquilerDto
    {
        public int Id { get; set; }

        public virtual Pelicula? Pelicula { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public int PeliculaId { get; set; }

        public Persona? Persona { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public int PersonaId { get; set; }

        public DateTime Fecha { get; set; }
    }
}
