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
        public IQueryable<TEntity> GetAll(params Expression<Func<TEntity, object>>[] includes)
        {
            var query = Entities.AsQueryable();

            if (includes != null)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
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

        public IQueryable<TEntity> List(Expression<Func<TEntity, bool>> condition, params Expression<Func<TEntity, object>>[] includes)
        {

            var query = Entities.Where(condition);

            if (includes != null)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }

            return query;
        }

        public TEntity GetById(int id)
        {
            return this.Entities.Find(id);
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
