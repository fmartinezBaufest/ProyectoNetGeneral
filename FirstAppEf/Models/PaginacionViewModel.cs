using System.Reflection.Metadata.Ecma335;

namespace FirstAppEf.Models
{
    public class PaginacionViewModel
    {
        public int Pagina { get; set; } = 1;

        public int recordsPorPagina = 10;

        public readonly int cantidadMaximaRecordsPorPagina = 200;
        public int RecordsPorPagina
        {
            get
            {
                return recordsPorPagina;
            }

            set 
            {
                recordsPorPagina = (value) > cantidadMaximaRecordsPorPagina ? 
                    cantidadMaximaRecordsPorPagina : value;
            }

        }

        public int recordsASaltar => recordsPorPagina * (Pagina - 1);
    }
}
