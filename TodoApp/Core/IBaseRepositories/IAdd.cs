using Core.Entities;

namespace Core.IBaseRepositories
{
    public interface IAdd<TEntity> where TEntity : class, IEntity, new()
    {
        int Add(TEntity entity);
    }
}
