using Core.Entities;

namespace Core.IBaseRepositories
{
    public interface IGetById<TEntity, TKey> where TEntity : class, IEntity, new()
    {
        TEntity GetById(TKey key);
    }
}
