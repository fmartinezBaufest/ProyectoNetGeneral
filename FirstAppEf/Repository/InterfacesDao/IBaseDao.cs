using System.Linq.Expressions;

namespace FirstAppEf.Repository.InterfacesDao
{
    public interface IBaseDao<TEntity, TEntityDto>
    {
        IEnumerable<TEntityDto> GetAll(string includeProperties = "");
        IEnumerable<TEntityDto> GetAll();

        TEntityDto Add(TEntityDto entity);
        TEntityDto GetById(int id);
        TEntityDto Update(TEntityDto entity, int id);
        void Delete(int id);
        IEnumerable<TEntityDto> Find(Expression<Func<TEntity, bool>> condition, string includeProperties = "");
    }
}
