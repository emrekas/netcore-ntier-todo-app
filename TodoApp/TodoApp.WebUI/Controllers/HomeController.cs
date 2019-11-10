using Microsoft.AspNetCore.Mvc;
using TodoApp.Business.IServices;
using TodoApp.DTO;

namespace TodoApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITaskService _taskService;

        public HomeController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_taskService.GetAllTask());
        }

        [HttpPost]
        public IActionResult AddTask(TaskDto taskDto)
        {
            _taskService.AddTask(taskDto);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdateTask(TaskDto taskDto)
        {
            _taskService.UpdateTask(taskDto);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeleteTask(int id) => Ok(_taskService.DeleteTaskById(id));
    }
}
