using Microsoft.AspNetCore.Mvc;
using ToDoItemList.Model;

namespace ToDoItemList.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(TodoItem todoItem)
        {
            return View();
        }
    }
}
