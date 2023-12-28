using AutoMapper;
using FirstAppEf;
using FirstAppEf.Models;
using FirstAppEf.Repository.Dao;
using FirstAppEf.Repository.Entities;
using FirstAppEf.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Moq;
using NuGet.Protocol.Core.Types;
using static FirstAppEf.Repository.InterfacesDao.IRepository;

namespace TestProject1
{
    [TestClass]
    public class BaseDaoTest
    {
        // Mocks para IRepository y IMapper
        private Mock<IRepository<Persona>> repositoryMock;
        private Mock<AutoMapper.IMapper> mapperMock;
        private IMapper mapper;
        private AplicationDbContext context;
        private Repository<Persona> repository;
        private BaseDao<Persona, PersonaDto> baseDao;
        private IDbContextTransaction transaction;



        [TestInitialize]
        public void Initialize()
        {
            var options = new DbContextOptionsBuilder<AplicationDbContext>()
               .UseInMemoryDatabase(databaseName: "PruebasEfAver")
               .Options;

            context = new AplicationDbContext(options);

           

            var profile = new AutoMapperProfile();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(profile));
            mapper = new Mapper(configuration);

            repository = new Repository<Persona>(context, mapper);

            baseDao = new BaseDao<Persona, PersonaDto>(repository, mapper);
        }

        [TestMethod]
        public void GetAllTest()
        {
            // Act
            var listPersons = new List<Persona>
            {
                new Persona { Id = 1, Name = "Juan", LastName = "Pérez", Dni = "12345678", Age = "25" },
                new Persona { Id = 2, Name = "María", LastName = "Gómez", Dni = "98765432", Age = "30" },
                new Persona { Id = 3, Name = "Carlos", LastName = "Rodríguez", Dni = "54321678", Age = "22" },
                // Agrega más instancias según sea necesario
            };

            context.Personas.AddRange(listPersons);

            context.SaveChanges();

            var res = baseDao.GetAll();

            // Assert
            Assert.IsNotNull(res);
            Assert.AreEqual(listPersons.Count, res.Count());
            Assert.IsTrue(res.All(p => listPersons.Any(lp => lp.Id == p.Id)));
            Assert.IsFalse(res.Any(p => p.Id == 4));

        }

        [TestMethod]
        public void GetByIdCorrect()
        {
            // Act
            var listPersons = new List<Persona>
            {
                new Persona { Id = 1, Name = "Juan", LastName = "Pérez", Dni = "12345678", Age = "25" },
                new Persona { Id = 2, Name = "María", LastName = "Gómez", Dni = "98765432", Age = "30" },
                new Persona { Id = 3, Name = "Carlos", LastName = "Rodríguez", Dni = "54321678", Age = "22" },
                // Agrega más instancias según sea necesario
            };

            context.Personas.AddRange(listPersons);

            context.SaveChanges();

            var res = baseDao.GetById(2);

            // Assert
            Assert.AreEqual(res.Id, 2);
            Assert.AreEqual("María", res.Name);
            Assert.AreEqual("Gómez", res.LastName);
            Assert.AreEqual("98765432", res.Dni);
            Assert.AreEqual("30", res.Age);


        }

        [TestMethod]
        public void DeleteById()
        {
            // Act
            var listPersons = new List<Persona>
            {
                new Persona { Id = 1, Name = "Juan", LastName = "Pérez", Dni = "12345678", Age = "25" },
                new Persona { Id = 2, Name = "María", LastName = "Gómez", Dni = "98765432", Age = "30" },
                new Persona { Id = 3, Name = "Carlos", LastName = "Rodríguez", Dni = "54321678", Age = "22" },
                // Agrega más instancias según sea necesario
            };

            context.Personas.AddRange(listPersons);

            context.SaveChanges();

            baseDao.Delete(2);

            var res = baseDao.GetAll();

            // Assert
            Assert.IsFalse(res.Any(x => x.Id == 2));


        }

        [TestCleanup]
        public void LimpiarDespuesDeLaPrueba()
        {
            // Deshacer transacción y liberar recursos del contexto
            context.Database.EnsureDeleted();
            context.Dispose();
        }
    }
}