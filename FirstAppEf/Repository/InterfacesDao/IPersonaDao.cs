
using FirstAppEf.Models;
using FirstAppEf.Repository.Entities;

namespace FirstAppEf.Repository.InterfacesDao
{
    public interface IPersonaDao : IBaseDao<Persona, PersonaDto>
    {
        PersonaDto? GetByDni(string dni);
    }
}
