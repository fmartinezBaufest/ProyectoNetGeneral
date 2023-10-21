using FirstAppEf.Repository.Entities;
using System.ComponentModel.DataAnnotations;

namespace FirstAppEf.Models
{
    public class GeneroDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string Nombre { get; set; }
    }
}
