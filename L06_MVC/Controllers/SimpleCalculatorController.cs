using Microsoft.AspNetCore.Mvc;

namespace L06_MVC.Controllers
{
    public class SimpleCalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormCollection formIndhold)
        {
            var abc = "abcc";

            Console.WriteLine("Yes");
            int tal1 = Int32.Parse(formIndhold["Tal1"]);
            int tal2 = Int32.Parse(formIndhold["Tal2"]);
            Console.WriteLine("Operant:" + formIndhold["operation"].ToString());

            double result=0.0;

            switch (formIndhold["operation"])
            {
                case "+":
                    result = tal1 + tal2;
                    break;
                case "-":
                    result = tal1 - tal2;
                    break;
                case "*":
                    result = tal1 * tal2;
                    break;
                case "/":
                    if(tal1==0 || tal2 == 0) ViewBag.Fejl= "Fejl - Ingen division med 0";
                    else result = tal1 / tal2;
                    break;
            }

            ViewBag.FormIndhold = formIndhold;
            ViewBag.Result = result.ToString();

            return View();
        }
    }
}
