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

        public IEnumerable<PeliculaDto> GetPeliculas()
        {
            return this.PeliculaDao.GetAll(x => x.Genero);
        }
    }
}
