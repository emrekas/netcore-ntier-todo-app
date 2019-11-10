using Core.Entities;

namespace Core.IBaseRepositories
{
    public interface IUpdate<TEntity> where TEntity : class, IEntity, new()
    {
        int Update(TEntity entity);
    }
}
