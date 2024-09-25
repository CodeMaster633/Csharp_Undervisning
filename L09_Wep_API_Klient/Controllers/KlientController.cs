using L09_Web_API_Klient.Models;
using Microsoft.AspNetCore.Mvc;

namespace L09_Web_API_Klient.Controllers
{
    public class KlientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetPersoner(IFormCollection formIndhold)
        {
            HttpClient klient = new HttpClient();

            List<Person> personer = await klient.GetFromJsonAsync<List<Person>>("https://localhost:7074/api/Values/getPersoner");

            return View("Index", personer);
        }

        [HttpGet]
        public async Task<IActionResult> GetQuote(IFormCollection formIndhold)
        {
            HttpClient klient = new HttpClient();

            string quote = await klient.GetFromJsonAsync<string>("https://www.tronalddump.io/random/quote ");

            return View("Index", quote);
        }
    }


}