using Core.Entities;

namespace Core.IBaseRepositories
{
    public interface IDelete<TEntity> where TEntity : class, IEntity, new()
    {
        int Delete(TEntity entity);
    }
}
