using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.IBaseRepositories
{
    public interface IGetAllByExp<T> where T : class, new()
    {
        IEnumerable<T> GetAllByExp(Expression<Func<T, bool>> exp = null);
    }
}
