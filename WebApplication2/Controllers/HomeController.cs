﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
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
