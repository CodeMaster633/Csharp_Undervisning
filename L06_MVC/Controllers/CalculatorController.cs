using Microsoft.AspNetCore.Mvc;

namespace L06_MVC.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult TimeCalculator()
        {
          

            return View() ;
        }
        [HttpPost]
        public ActionResult TimeCalculator(IFormCollection formCollection)
        {
            int hours = Int32.Parse(formCollection["Hours"]);
            int minutes = Int32.Parse(formCollection["Minutes"]);
            int seconds = Int32.Parse(formCollection["Seconds"]);

            TimeSpan ts = new TimeSpan(0, hours, minutes, seconds);
            double total = ts.TotalSeconds;

            ViewBag.Hours = hours;
            ViewBag.Minutes = minutes;
            ViewBag.Seconds = seconds;
            ViewBag.Total = total;

            return View("TimeCalculatorResult");
        }
}
    }

