using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MySimpleLibrary.Controllers
{
    [Route("/")]
    [Authorize]
    public class HomeController : Controller
    {
        static List<string> books = new List<string>();

        public HomeController()
        {
            if (books.Count == 0)
            {
                books.Add("Angels and Demons");
                books.Add("Davinci Code");
                books.Add("Harry Potter");
            }
        }

        public IActionResult Index()
        {
            ViewBag.Books = books;
            return View();
        }
    }
}
