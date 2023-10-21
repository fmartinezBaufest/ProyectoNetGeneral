using System.ComponentModel.DataAnnotations;

namespace FirstAppEf.Models
{
    public class PersonaDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Este campo es requerido")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string Dni { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string Age { get; set; }
    }
}
