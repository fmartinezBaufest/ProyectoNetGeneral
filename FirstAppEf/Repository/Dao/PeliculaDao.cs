using AutoMapper;
using FirstAppEf.Models;
using FirstAppEf.Repository.Entities;
using FirstAppEf.Repository.InterfacesDao;
using static FirstAppEf.Repository.InterfacesDao.IRepository;

namespace FirstAppEf.Repository.Dao
{
    public class PeliculaDao : BaseDao<Pelicula, PeliculaDto>, IPeliculaDao
    {
        public PeliculaDao(IRepository<Pelicula> repository, IMapper mapper) 
            : base(repository, mapper)
        {
        }
    }
}
