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


        [HttpGet("{id}/{author}")]//If the route matches a parameter match it to the id
        public IActionResult Index(int id,string author)
        {
            Book book                = library.FindBookById(id);
            List<Book> booksByAuthor = library.FindByAuthor(author);

            ViewBag.Book            = book;
            ViewBag.BooksByAuthor   = booksByAuthor;

            return View();
        }
    }
}
