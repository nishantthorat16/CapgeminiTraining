using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoItemList.Model;

namespace ToDoItemList.Controllers
{
    [Route("/")]
    public class HomeController 
        : Controller
    {
        static List<TodoItem> todoItems = new List<TodoItem>();

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult 
            Index(TodoItem todoItem)
        {
            todoItems.Add(todoItem);

            ViewBag.TodoItems = todoItems;

            return View();
        }
    }
}
