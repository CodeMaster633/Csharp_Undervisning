using Microsoft.AspNetCore.Mvc;

namespace L06_MVC.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult TimeCalculator()
        {
            return View();
        }
    }
}
