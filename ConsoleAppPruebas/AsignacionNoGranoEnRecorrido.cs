using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPruebas
{
    public class AsignacionNoGranoEnRecorrido
    {
        public virtual int Id { get; set; }

        public virtual Calle CallePlanta { get; set; }

        [Column("CallePlanta_Id")]
        public virtual int? CallePlantaId { get; set; }

        public virtual Recorrido Recorrido { get; set; }

        [Column("Recorrido_Id")]
        public virtual int RecorridoId { get; set; }

        public bool AplicaConteo { get; set; }
    }
}
