using System.Linq.Expressions;

namespace FirstAppEf.Repository.InterfacesDao
{
    public interface IRepository
    {
        public interface IRepository<TEntity> where TEntity : class
        {
            IQueryable<TEntity> GetAll(string includeProperties = "");
            IQueryable<TEntity> GetAll();
            TEntity Insert(TEntity entity);
            IQueryable<TEntity> List(Expression<Func<TEntity, bool>> condition, string includeProperties = "");
            TEntity GetById(int id);
            void Save();
            void Delete(TEntity entity);
            TEntity GetOneBy(Expression<Func<TEntity, bool>> condition, string includeProperties = "");
        }
    }
}
