using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassingDataThroughParameters.Controllers
{
    [Route("/managebooks")]
    public class ManageBooksController : Controller
    {
        Library library = new Library();

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Book book)
        {
            if(ModelState.IsValid)
            {
                library.AddBook(book);
                //Add the book the library
                Response.Redirect("/");
            }

            return View();
        }
    }
}
