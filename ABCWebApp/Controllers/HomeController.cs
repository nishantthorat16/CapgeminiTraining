using ABCLibrary;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ABCWebApp.Controllers
{
    [Route("/")]
    [Authorize]
    public class HomeController : Controller
    {
        LibraryDbContext context;

        public HomeController(LibraryDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
           
            ViewBag.Books = context.Books;
            return View();
        }

        [HttpPost]
        public IActionResult Index(string searchterm)
        {

            ViewBag.Books = context.Books.Where(d => d.Title.Contains(searchterm)
                                        || d.Author.Contains(searchterm));
            return View();
        }
    }
}
