using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MySimpleLibrary.Controllers
{
    [Route("/login")]
    public class LoginController : Controller {
        List<User> users = new List<User>();
        public LoginController(){
            users.Add(new User("sree"   , "12345", "Admin"));
            users.Add(new User("user001", "12345", "Member"));
        }

        [HttpGet]
        public IActionResult Index(){
            return View();
        }

        [HttpPost]
        public IActionResult Index(
            string username,
            string password) {
            User loggedInUser = null;
            foreach(var user in users){
                if(user.UserName == username && password == user.Password){
                    loggedInUser = user;
                    break;
                }
            }
            if(loggedInUser != null){

            }
            else{
                ViewBag.Error = "Login Failed";
            }

            return View();
        }
    }
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }   
        public string Role     { get; set; }
        public User(string userName, string password, string role)
        {
            UserName = userName;
            Password = password;
            Role = role;
        }
    }
}
