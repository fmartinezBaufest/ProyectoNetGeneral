using FirstAppEf.Business.ExceptionDni;
using FirstAppEf.Business.Interfaces;
using FirstAppEf.Models;
using FirstAppEf.Repository.Dao;
using FirstAppEf.Repository.Entities;
using FirstAppEf.Repository.InterfacesDao;
using Microsoft.IdentityModel.Tokens;
using System.Linq;

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
            return this.personaDao.GetAll()
                .OrderByDescending(p => p.Id)
                .Skip(paginacionViewModel.recordsASaltar)
                .Take(paginacionViewModel.recordsPorPagina);
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


        public void DeletePersona(int id)
        {
            this.personaDao.Delete(id);

        }

        public IEnumerable<PersonaDto> FindPagination(PaginacionViewModel paginacionViewModel)
        {
            return !paginacionViewModel.TextoDeBusqueda.IsNullOrEmpty() ? this.personaDao.Find(x => x.Name.Contains(paginacionViewModel.TextoDeBusqueda)
                || x.LastName.Contains(paginacionViewModel.TextoDeBusqueda)
                || x.Age.Contains(paginacionViewModel.TextoDeBusqueda)
                || x.Dni.Contains(paginacionViewModel.TextoDeBusqueda)).OrderByDescending(p => p.Id)
                .Skip(paginacionViewModel.recordsASaltar)
                .Take(paginacionViewModel.recordsPorPagina) : this.personaDao.GetAll().OrderByDescending(p => p.Id)
                                                                .Skip(paginacionViewModel.recordsASaltar)
                                                                .Take(paginacionViewModel.recordsPorPagina);


        }

        public IEnumerable<PersonaDto> FindByData(string data)
        {
            return !data.IsNullOrEmpty() ? this.personaDao.Find(x => x.Name.Contains(data)
                || x.LastName.Contains(data)
                || x.Age.Contains(data)
                || x.Dni.Contains(data)).OrderByDescending(p => p.Id) : this.personaDao.GetAll();

        }


    }
}
