using System.Linq.Expressions;

namespace FirstAppEf.Repository.InterfacesDao
{
    public interface IBaseDao<TEntity, TEntityDto>
    {
        IEnumerable<TEntityDto> GetAll(params Expression<Func<TEntity, object>>[] includes);
        IEnumerable<TEntityDto> GetAll();

        TEntityDto Add(TEntityDto entity);
        TEntityDto GetById(int id);
        TEntityDto Update(TEntityDto entity, int id);
    }
}
