namespace Core.IBaseRepositories
{
    public interface IDeleteById<TKey>
    {
        int DeleteById(TKey key);
    }
}
