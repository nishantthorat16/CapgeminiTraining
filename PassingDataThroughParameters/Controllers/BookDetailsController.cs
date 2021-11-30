using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassingDataThroughParameters.Controllers
{
    [Route("/bookdetails")]
    public class BookDetailsController : Controller
    {
        Library library = new Library();


        [HttpGet("{id}")]//If the route matches a parameter match it to the id
        public IActionResult Index(int id)
        {
            Book book = library.FindBookById(id);
            ViewBag.Book = book;

            return View();
        }
    }
}
