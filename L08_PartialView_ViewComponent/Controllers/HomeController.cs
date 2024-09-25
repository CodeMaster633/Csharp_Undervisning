using L08_PartialView_ViewComponent.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace L08_PartialView_ViewComponent.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		public List<Person> Persons { get; set; }

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}
		public IActionResult VisAlle()
		{
			Persons = new List<Person>();
			Persons.Add(new Person("Benjamin", 26));
			Persons.Add(new Person("Mikkel", 42));
			Persons.Add(new Person("Nikolaj", 39));

			ViewBag.Persons = Persons;

			return View();
		}
        public IActionResult VisEn()
        {
            Persons = new List<Person>();
            Persons.Add(new Person("Benjamin", 26));
            Persons.Add(new Person("Mikkel", 42));
            Persons.Add(new Person("Nikolaj", 39));

            ViewBag.Persons = Persons;

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

		private List<Person> AllePersoner()
		{
			return Persons;
		}
	}
}
