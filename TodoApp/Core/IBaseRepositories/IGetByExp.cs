using System;
using System.Linq.Expressions;

namespace Core.IBaseRepositories
{
    public interface IGetByExp<T> where T : class, new()
    {
        T GetByExp(Expression<Func<T, bool>> exp);
    }
}
