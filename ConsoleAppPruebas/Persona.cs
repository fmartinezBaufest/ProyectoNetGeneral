using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPruebas
{
    public class Persona
    {
        [BsonId]
        public int Id { get; set; }

        [BsonElement("nombre")]
        public string Nombre { get; set; }
    }
}
