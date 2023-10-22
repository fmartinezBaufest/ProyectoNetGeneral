using AutoMapper;
using Microsoft.EntityFrameworkCore;
using static FirstAppEf.Repository.InterfacesDao.IRepository;
using System.Linq.Expressions;

namespace FirstAppEf.Repository.Dao
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly AplicationDbContext Context;
        private DbSet<TEntity> Entities;
        private readonly IMapper Mapper;

        string errorMessage = string.Empty;
        public Repository(AplicationDbContext context, IMapper mapper)
        {
            this.Context = context;
            Entities = Context.Set<TEntity>();
            this.Mapper = mapper;
        }
        public IQueryable<TEntity> GetAll(string includeProperties = "")
        {
            var query = Entities.AsQueryable();

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            return query;
        }
        public TEntity Insert(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            var result = this.Entities.Add(entity);
            Context.SaveChanges();

            return result.Entity;
        }

        public IQueryable<TEntity> List(Expression<Func<TEntity, bool>> condition, string includeProperties = "")
        {

            var query = Entities.Where(condition);

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            return query;
        }

        public TEntity GetById(int id)
        {
            return this.Entities.Find(id);
        }

        public void Delete(TEntity entity)
        {
            this.Entities.Remove(entity);
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        public IQueryable<TEntity> GetAll()
        {
            return this.Entities;
        }
    }
}
