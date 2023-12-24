using AutoMapper;
using FirstAppEf.Models;
using FirstAppEf.Repository.Entities;
using FirstAppEf.Repository.InterfacesDao;
using static FirstAppEf.Repository.InterfacesDao.IRepository;

namespace FirstAppEf.Repository.Dao
{
    public class AlquilerDao : BaseDao<Alquiler, AlquilerDto>, IAlquilerDao
    {
        public AlquilerDao(IRepository<Alquiler> repository, IMapper mapper) 
            : base(repository, mapper)
        {
        }
    }
}
