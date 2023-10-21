using System.Reflection.Metadata.Ecma335;

namespace FirstAppEf.Models
{
    public class PaginacionRespuesta<T>
    {
        public IEnumerable<T> Elementos { get; set; }

        public int Pagina { get; set; }

        public int RecordsPorPagina { get; set; } = 10;

        public int CantidadTotalDeRecords { get; set; }

        public int CantidadDePaginas => (int)Math.Ceiling((double)CantidadTotalDeRecords / RecordsPorPagina);
    }
}
