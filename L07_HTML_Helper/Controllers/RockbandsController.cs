using Microsoft.AspNetCore.Mvc;

namespace L06_MVC.Controllers
{
    
    public class RockbandsController : Controller
    {
        public IActionResult Index()
        {
            string[] rockbands = new string[]{ "Skillet", "Wolves at the gate", "Disciple" };

            ViewBag.rockbands = rockbands;

            return View();
        }
    }
}
