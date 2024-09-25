using L06_MVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace L06_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string name = "Benjamin";
            int age = 26;
            DateTime birthday = new DateTime(1998,08,02);

            //ViewBag.name = name;      
            //ViewBag.age = age;
            //ViewBag.birthday = birthday;

            //new Person { Name = name, Age = age, Birthday = birthday };

            //return View();
            return View(new HomeModel(24));
        }
    }
}
