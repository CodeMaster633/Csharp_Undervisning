using L08_Layout__mm.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace L08_Layout__mm.Controllers
{
    public class HomeController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sale()
        {
            return View();
        }
		public IActionResult MoreSales()
		{
			return View();
		}

		public IActionResult Buy()
		{
			return View();
		}

		public IActionResult BuyAndSell()
		{
			return View();
		}

	}
}
