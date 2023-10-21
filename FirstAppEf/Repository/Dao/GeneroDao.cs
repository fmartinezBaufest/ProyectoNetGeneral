using AutoMapper;
using FirstAppEf.Models;
using FirstAppEf.Repository.Entities;
using FirstAppEf.Repository.InterfacesDao;
using static FirstAppEf.Repository.InterfacesDao.IRepository;

namespace FirstAppEf.Repository.Dao
{
    public class GeneroDao : BaseDao<Genero, GeneroDto>, IGeneroDao
    {
        public GeneroDao(IRepository<Genero> repository, IMapper mapper) 
            : base(repository, mapper)
        {
        }
    }
}
