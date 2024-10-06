using L10_Entity_Framework.Models;
using L10_Entity_Framework.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace L10_Entity_Framework.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            BogContext context = new BogContext();
            context.Database.EnsureCreated();


            foreach (var bog in context.Boger)
            {
                Console.WriteLine(bog.Name);
            }
             
            Bog bog1 = context.Boger.Where(b => b.BogID == 1).First(); //bog

            bog1.Name = "dsajfk Herre";
            context.SaveChanges();

            ViewBag.Boger = context.Boger;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
