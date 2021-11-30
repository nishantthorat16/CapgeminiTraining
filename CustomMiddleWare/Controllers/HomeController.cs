using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomMiddleWare.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Action2")]
        public IActionResult Action2()
        {
            return View();
        }

        [HttpGet("Action3")]
        public IActionResult Action3()
        {
            return View();
        }
    }
}
