using Core.Entities;

namespace Core.IBaseRepositories
{
    public interface IRepository<TEntity, TKey>
            : IAdd<TEntity>
            , IDelete<TEntity>
            , IDeleteById<TKey>
            , IGetAllByExp<TEntity>
            , IUpdate<TEntity>
            , IGetById<TEntity, TKey>
            , IGetByExp<TEntity>
           where TEntity : class, IEntity, new()
    {
    }
}
