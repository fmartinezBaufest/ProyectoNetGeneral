using FirstAppEf.Business.ExceptionDni;
using FirstAppEf.Business.Interfaces;
using FirstAppEf.Models;
using FirstAppEf.Repository.Dao;
using FirstAppEf.Repository.Entities;
using FirstAppEf.Repository.InterfacesDao;

namespace FirstAppEf.Business
{
    public class PersonaBusiness : IPersonaBusiness
    {
        private readonly IPersonaDao personaDao;

        public PersonaBusiness(IPersonaDao personaDao)
        {
            this.personaDao = personaDao;
        }

        public PersonaDto Crear(PersonaDto persona)
        {
            var res = GetByDni(persona.Dni);

            if(res != null)
            {
                throw new DniException("El usuario ya existe - el dni esta en la base");
            }

            return this.personaDao.Add(persona);
            
        }

        public PersonaDto GetByDni(string dni)
        {
            return this.personaDao.GetByDni(dni);
        }
        public IEnumerable<PersonaDto> GetAllPaginado(PaginacionViewModel paginacionViewModel)
        {
            return this.personaDao.GetAll().Skip(paginacionViewModel.recordsASaltar).Take(paginacionViewModel.recordsPorPagina).OrderBy(x => x.Id);
        }

        public PersonaDto GetPersonById(int id)
        {
            var result = this.personaDao.GetById(id);

            if(result == null)
            {
                throw new Exception("error en la busqueda");
            }

            return result;
        }

        public PersonaDto Actualizar(PersonaDto persona)
        {
            return this.personaDao.Update(persona, persona.Id);
        }

        public int GetTotalPersonas()
        {
            return this.personaDao.GetAll().Count();
        }

        
    }
}
