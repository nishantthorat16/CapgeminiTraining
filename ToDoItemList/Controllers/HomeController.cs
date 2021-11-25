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
        ITodoItemService service;

        //Dependency Injection
        //Inversion of Control - The process of coding against a interface insted of a class
        public HomeController(ITodoItemService todoItemService)
        {
            service = todoItemService; 
            //new ToDoItemFileService(); 
            ///new ToDoListService();
        }

        [HttpGet]
        public IActionResult Index()
        {
            var todoItems = service.GetTodoItems();
            ViewBag.TodoItems = todoItems;
            return View();
        }

        [HttpPost]
        public IActionResult 
            Index(TodoItem todoItem)
        {
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
