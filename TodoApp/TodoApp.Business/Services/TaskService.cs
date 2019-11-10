using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TodoApp.Business.IServices;
using TodoApp.DataAccess.Interfaces;
using TodoApp.DTO;
using TodoApp.Entities;

namespace TodoApp.Business.Services
{
    public class TaskService : ITaskService
    {
        //DTO kullanımında AutoMapper gibi paketler kullanılabilir.

        private readonly ITaskDal _taskDal;

        public TaskService(ITaskDal taskDal)
        {
            _taskDal = taskDal;
        }

        public int AddTask(TaskDto taskDto)
        {
            var task = new Task
            {
                Name = taskDto.Name,
                Description = taskDto.Description,
                BeginDate = taskDto.BeginDate,
                EndDate = taskDto.EndDate
            };
            return _taskDal.Add(task);
        }

        public int UpdateTask(TaskDto taskDto)
        {
            var task = new Task
            {
                Id = taskDto.Id,
                Name = taskDto.Name,
                Description = taskDto.Description,
                BeginDate = taskDto.BeginDate,
                EndDate = taskDto.EndDate
            };
            return _taskDal.Update(task);
        }

        public int DeleteTaskById(int id)
        {
            return _taskDal.DeleteById(id);
        }

        public IEnumerable<TaskDto> GetAllTask(Expression<Func<Task, bool>> exp = null)
        {
            var tasks = _taskDal.GetAllByExp(exp).ToList();
            var taskDtoList = new List<TaskDto>();

            tasks.ForEach(t =>
            {
                taskDtoList.Add(new TaskDto
                {
                    Id = t.Id,
                    Name = t.Name,
                    Description = t.Description,
                    BeginDate = t.BeginDate,
                    EndDate = t.EndDate
                });
            });

            return taskDtoList;
        }
    }
}
