using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TodoApp.DTO;
using TodoApp.Entities;

namespace TodoApp.Business.IServices
{
    public interface ITaskService
    {
        int AddTask(TaskDto task);
        int UpdateTask(TaskDto task);
        int DeleteTaskById(int id);
        IEnumerable<TaskDto> GetAllTask(Expression<Func<Task, bool>> exp = null);
    }
}
