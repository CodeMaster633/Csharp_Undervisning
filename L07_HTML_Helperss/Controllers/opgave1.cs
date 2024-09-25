using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics.Metrics;
using Newtonsoft.Json;

namespace L07_HTML_Helperss.Controllers
{
    public class opgave1 : Controller
    {
        List<SelectListItem> countriesList = new List<SelectListItem>();


        public IActionResult Index()
        {
            countriesList.Add(new SelectListItem { Text = "China", Value = "CN" });
            countriesList.Add(new SelectListItem { Text = "Denmark", Value = "DK" });
            countriesList.Add(new SelectListItem { Text = "United Kingdom", Value = "UK" });
            countriesList.Add(new SelectListItem { Text = "United States of America", Value = "USA" });
            ViewBag.Countries = countriesList;

            //ViewBag.CountryCode = Country;
            Console.WriteLine("Test... ");

            return View();
        }

        [HttpPost]
        public ActionResult Index(string Countries)
        {
            Console.WriteLine("Index 2 ");

            countriesList.Add(new SelectListItem { Text = "China", Value = "CN" });
            countriesList.Add(new SelectListItem { Text = "Denmark", Value = "DK" });
            countriesList.Add(new SelectListItem { Text = "United Kingdom", Value = "UK" });
            countriesList.Add(new SelectListItem { Text = "United States of America", Value = "USA" });
            ViewBag.Countries = countriesList;
            ViewBag.CountryCode = Countries;
            return View();

        }

        [HttpPost]
        public ActionResult AddCountry(IFormCollection formData) {
            Console.WriteLine("Index 3 ");

            if (HttpContext.Session.GetString("countriesList") == null)
            {
                countriesList.Add(new SelectListItem { Text = "China", Value = "CN" });
                countriesList.Add(new SelectListItem { Text = "Denmark", Value = "DK" });
                countriesList.Add(new SelectListItem { Text = "France", Value = "FR" });
                countriesList.Add(new SelectListItem { Text = "USA", Value = "US" });
                HttpContext.Session.SetString("countriesList", JsonConvert.SerializeObject(countriesList));
            }
            else
            {
                // if the sessionvariale is set you'll make a reference to it
                // note that session variable is not strongly typed
                // that's because all types of variables can be stored in sessions
                // therefore you must typecast it to the right type when you assign it to a variable
                countriesList = JsonConvert.DeserializeObject<List<SelectListItem>>(HttpContext.Session.GetString("countriesList"));

            }


            ViewBag.FormData = formData;

            countriesList.Add(new SelectListItem { Text = formData["Land"], Value = formData["Kode"] });

            ViewBag.Countries = countriesList;

            HttpContext.Session.SetString("countriesList", JsonConvert.SerializeObject(countriesList));



            return View("Index");

        }
    }
}
