using ABCLibrary;
using ABCLibrary.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ABCWebApp.Controllers
{
    [Route("/addbook")]
    [Authorize(Roles = "Admin")]
    public class AddBookController : Controller
    {
        IBookRepository bookRepository;

        public AddBookController(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

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
                var b = this.bookRepository.Add(book);

                if(b == null)
                {
                    Response.Redirect("/page1");
                }
                else
                    Response.Redirect("/page2");
            }
            return View(book);
        }
    }
}
