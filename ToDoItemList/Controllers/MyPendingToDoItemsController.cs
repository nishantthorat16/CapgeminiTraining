using Microsoft.AspNetCore.Mvc;
using TodoItemsLibrary;

namespace ToDoItemList.Controllers
{
    public class MyPendingToDoItemsController : Controller
    {
        ITodoItemService todoItemService;

        public MyPendingToDoItemsController(ITodoItemService todoItemService)
        {
            
            this.todoItemService = todoItemService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
