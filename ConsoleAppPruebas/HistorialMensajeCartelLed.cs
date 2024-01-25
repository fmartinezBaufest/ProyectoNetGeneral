using System.ComponentModel.DataAnnotations;

namespace ConsoleAppPruebas
{
    public class HistorialMensajeCartelLed
    {
        public virtual int Id { get; set; }

        public virtual string Mensaje { get; set; }

        public virtual DateTime? FechaUltimaModificacion { get; set; }

        public virtual Calle Calle { get; set; }

        [Required]
        public virtual MensajeCartelLed MensajeCartelLed { get; set; }
        public virtual Recorrido Recorrido { get; set; }
    }
}