using Microsoft.AspNetCore.Mvc;

namespace MyFirstMVCApp.Controllers
{
    [Route("/")]
    //Controller
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string myname
            ,int age)
        {
            ViewBag.Message = "Hello," + myname;
            return View();
        }



        [Route("/about")]
        public IActionResult AboutMe()
        {
            return View();
        }
    }
}
