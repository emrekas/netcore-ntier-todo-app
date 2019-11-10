using Core.IBaseRepositories;
using TodoApp.Entities;

namespace TodoApp.DataAccess.Interfaces
{
    public interface ITaskDal : IRepository<Task, int> { }
}
