using ABCLibrary;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ABCWebApp.Controllers
{
    [Route("/login")]
    public class LoginController : Controller
    {
        LibraryDbContext context;

        public LoginController(LibraryDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(
            string username,
            string password)
        {
            ABCLibrary.User user     = context.Users.FirstOrDefault(d => d.Email == username 
                                                    && d.Password == password);

            if (user != null)
            {
                var claims = new[]
               {
                    new Claim(ClaimTypes.Name,user.Id.ToString()),
                    new Claim(ClaimTypes.Role,user.Role.ToString()),
                };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));

                Response.Redirect("/");
            }
            else
                ViewBag.Error = "Login Failed";

            return View();
        }
    }
}
