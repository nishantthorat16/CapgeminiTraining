using Microsoft.AspNetCore.Mvc;

namespace MyFirstMVCApp.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
