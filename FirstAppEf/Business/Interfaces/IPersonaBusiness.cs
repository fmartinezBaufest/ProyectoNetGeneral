using FirstAppEf.Models;

namespace FirstAppEf.Business.Interfaces
{
    public interface IPersonaBusiness
    {
        PersonaDto Crear(PersonaDto persona);

        IEnumerable<PersonaDto> GetAllPaginado(PaginacionViewModel paginacionViewModel);
        PersonaDto GetByDni(string dni);
        PersonaDto GetPersonById(int id);

        PersonaDto Actualizar(PersonaDto persona);
        int GetTotalPersonas();
        void DeletePersona(int id);
    }
}
