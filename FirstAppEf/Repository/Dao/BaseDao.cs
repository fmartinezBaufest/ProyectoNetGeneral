using AutoMapper;
using FirstAppEf.Migrations;
using FirstAppEf.Repository.Entities;
using FirstAppEf.Repository.InterfacesDao;
using System.Linq.Expressions;
using static FirstAppEf.Repository.InterfacesDao.IRepository;

namespace FirstAppEf.Repository.Dao
{
    public class BaseDao<TEntity, TEntityDto> : IBaseDao<TEntity, TEntityDto>
          where TEntity : class
          where TEntityDto : class
    {
        protected readonly IRepository<TEntity> Repository;
        protected readonly IMapper Mapper;
        public BaseDao(IRepository<TEntity> repository, IMapper mapper)
        {
            this.Repository = repository;
            this.Mapper = mapper;
        }
        public TEntityDto Add(TEntityDto entity)
        {
            var res = this.Repository.Insert(this.Mapper.Map<TEntityDto, TEntity>(entity));

            return this.Mapper.Map<TEntity, TEntityDto>(res);
        }

        public IEnumerable<TEntityDto> GetAll(string includeProperties = "")
        {
            return this.Mapper.Map<IEnumerable<TEntity>, IEnumerable<TEntityDto>>(this.Repository.GetAll(includeProperties));
        }

        public IEnumerable<TEntityDto> Find(Expression<Func<TEntity, bool>> condition, string includeProperties = "")
        {
            return this.Mapper.Map<IEnumerable<TEntity>, IEnumerable<TEntityDto>>(this.Repository.List(condition, includeProperties));
        }

        public IEnumerable<TEntityDto> GetAll()
        {
            return this.Mapper.Map<IEnumerable<TEntity>, IEnumerable<TEntityDto>>(this.Repository.GetAll());

        }

        public TEntityDto GetOneBy(Expression<Func<TEntity, bool>> condition, string includeProperties = "")
        {
            return this.Mapper.Map<TEntity, TEntityDto>(this.Repository.GetOneBy(condition, includeProperties));
        }

        public TEntityDto GetById(int id)
        {
            return this.Mapper.Map<TEntity, TEntityDto>(this.Repository.GetById(id));
        }

        public TEntityDto Update(TEntityDto entity, int id)
        {
            var entityBd = this.Repository.GetById(id);
            this.Mapper.Map(entity, entityBd);
            this.Repository.Save();
            return entity;
        }

        public void Delete(int id)
        {
            var entityBd = this.Repository.GetById(id);

            this.Repository.Delete(entityBd);

            this.Repository.Save();

        }


    }
}
