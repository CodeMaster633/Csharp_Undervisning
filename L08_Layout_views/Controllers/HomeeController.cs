using Microsoft.AspNetCore.Mvc;

namespace L08_Layout_views.Controllers
{
    public class HomeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Sale()
        {
            return View();
        }
    }
}
