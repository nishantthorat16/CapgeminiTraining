using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TodoItemsLibrary;

namespace ToDoItemList.Controllers
{
    [Route("/")]
    public class HomeController 
        : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult 
            Index(TodoItem todoItem)
        {
            ToDoListService service = new ToDoListService();

            try
            {
                service.Add(todoItem);
            }
            catch(Exception excp)
            {
                ViewBag.Error = excp.Message; ;
            }

            var todoItems = service.GetTodoItems();

            ViewBag.TodoItems = todoItems;

            return View();
        }
    }
}
