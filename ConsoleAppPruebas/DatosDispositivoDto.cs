using Microsoft.Extensions.Logging;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPruebas
{
    public class DatosDispositivoDto
    {
        [BsonId]
        [BsonElement("id")]
        public int Id { get; set; }

        [BsonElement("fecha")]
        public DateTime Fecha { get; set; }

        [BsonElement("evento")]
        public Evento Evento { get; set; }

        [BsonElement("mensaje")]
        public string Mensaje { get; set; }

        [BsonElement("codigoDispositivo")]
        public string CodigoDispositivo { get; set; }

        [BsonElement("descripcionDispositivo")]
        public string DescripcionDispositivo { get; set; }
    }
}
