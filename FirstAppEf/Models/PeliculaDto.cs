using FirstAppEf.Repository.Entities;
using System.ComponentModel.DataAnnotations;

namespace FirstAppEf.Models
{
    public class PeliculaDto
    {

        [Required(ErrorMessage ="Este campo es requerido")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public int Anio { get; set; }

        
        public IFormFile? Image { get; set; }

        public byte[]? ImageBytes { get; set; }


        [Required(ErrorMessage = "Este campo es requerido")]
        public int GeneroId { get; set; }

        public string? Genero { get; set; }
    }
}
