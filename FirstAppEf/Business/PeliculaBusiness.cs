using FirstAppEf.Business.ExceptionDni;
using FirstAppEf.Business.Interfaces;
using FirstAppEf.Models;
using FirstAppEf.Repository.InterfacesDao;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;

namespace FirstAppEf.Business
{
    public class PeliculaBusiness: IPeliculaBusiness
    {

        public IPeliculaDao PeliculaDao;
        private readonly IGeneroDao generoDao;

        public PeliculaBusiness(IPeliculaDao peliculaDao, IGeneroDao generoDao)
        {
            PeliculaDao = peliculaDao;
            this.generoDao = generoDao;
        }


        public PeliculaDto Crear(PeliculaDto pelicula)
        {

            if(pelicula.Image == null)
            {
                throw new Exception("se debe cargar un archivo");
            }

            var result = this.PeliculaDao.Add(pelicula);            

            return result;
        }

        public IEnumerable<GeneroDto> GetGeneros()
        {
            return this.generoDao.GetAll();
        }

        public IEnumerable<PeliculaDto> GetPeliculas(string name)
        {
            return this.PeliculaDao.GetAll("Genero");
        }

        public IEnumerable<PeliculaDto> GetPeliculasByName(string name)
        {
            return this.PeliculaDao.Find(condition: x => x.Nombre.Contains(name), includeProperties: "Genero");
        }

        public PeliculaDto GetPeliculaById(int id)
        {
            return this.PeliculaDao.GetOneBy(x => x.Id == id, "Genero");
        }

        public PeliculaDto GetPeliculaByName(string nombre)
        {
            return this.PeliculaDao.GetOneBy(x => x.Nombre.Contains(nombre), "Genero");
        }
    }
}
