using FirstAppEf.Models;

namespace FirstAppEf.Business.Interfaces
{
    public interface IPeliculaBusiness
    {
        PeliculaDto Crear(PeliculaDto pelicula);
        IEnumerable<GeneroDto> GetGeneros();
        PeliculaDto GetPeliculaById(int id);
        PeliculaDto GetPeliculaByName(string nombre);
        IEnumerable<PeliculaDto> GetPeliculas(string name);
        IEnumerable<PeliculaDto> GetPeliculasByName(string name);
    }
}
