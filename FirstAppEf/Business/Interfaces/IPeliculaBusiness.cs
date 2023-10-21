using FirstAppEf.Models;

namespace FirstAppEf.Business.Interfaces
{
    public interface IPeliculaBusiness
    {
        PeliculaDto Crear(PeliculaDto pelicula);
        IEnumerable<GeneroDto> GetGeneros();
        IEnumerable<PeliculaDto> GetPeliculas();
    }
}
