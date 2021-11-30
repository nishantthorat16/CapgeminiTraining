using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassingDataThroughParameters.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        Library library = new Library();
        public IActionResult Index()
        {
            ViewBag.Books = library.GetBooks();
            return View();
        }
    }
}
