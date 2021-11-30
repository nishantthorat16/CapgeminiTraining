using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomMiddleWare.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        IConfiguration config;

        public HomeController(IConfiguration config)
        {
            this.config = config;
        }

        public IActionResult Index()
        {
            var clientName = config.GetValue<string>("ClientInformation:Name");
            var dbInfo = config.GetValue<string>("ClientInformation:DatabaseServerInfo");

            ViewBag.ClientName = clientName;
            ViewBag.DbInfo = dbInfo;


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
