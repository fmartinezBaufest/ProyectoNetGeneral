using System.Linq.Expressions;

namespace FirstAppEf.Repository.InterfacesDao
{
    public interface IRepository
    {
        public interface IRepository<TEntity> where TEntity : class
        {
            IQueryable<TEntity> GetAll(params Expression<Func<TEntity, object>>[] includes);
            IQueryable<TEntity> GetAll();
            TEntity Insert(TEntity entity);
            IQueryable<TEntity> List(Expression<Func<TEntity, bool>> condition, params Expression<Func<TEntity, object>>[] includes);
            TEntity GetById(int id);
            void Save();
        }
    }
}
