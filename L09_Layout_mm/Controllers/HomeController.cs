using Microsoft.AspNetCore.Mvc;

namespace L09_Layout_mm.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
