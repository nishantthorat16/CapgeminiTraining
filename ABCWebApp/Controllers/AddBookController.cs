using ABCLibrary;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ABCWebApp.Controllers
{
    [Route("/addbook")]
    [Authorize(Roles = "Admin")]
    public class AddBookController : Controller
    {
        LibraryDbContext context;

        public AddBookController(LibraryDbContext context)
        {
            this.context = context;
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

                context.Books.Add(book);
                context.SaveChanges();

                Response.Redirect("/");
            }
            return View(book);
        }
    }
}
