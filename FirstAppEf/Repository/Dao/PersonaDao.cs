using AutoMapper;
using FirstAppEf.Models;
using FirstAppEf.Repository.Entities;
using FirstAppEf.Repository.InterfacesDao;
using static FirstAppEf.Repository.InterfacesDao.IRepository;

namespace FirstAppEf.Repository.Dao
{
    public class PersonaDao : BaseDao<Persona, PersonaDto>, IPersonaDao
    {
        public PersonaDao(IRepository<Persona> repository, IMapper mapper) 
            : base(repository, mapper)
        {
        }

        public PersonaDto? GetByDni(string dni)
        {
            var personaEntity = this.Repository.List(x => x.Dni == dni).FirstOrDefault();

            if (personaEntity != null)
            {
                return this.Mapper.Map<Persona, PersonaDto>(personaEntity);
            }

            // Si no se encuentra una persona con el DNI especificado, puedes devolver null de manera explícita.
            return null;


        }

        public PersonaDto Actualizar(PersonaDto persona)
        {

            return this.Actualizar(persona);
            

        }
    }
}
