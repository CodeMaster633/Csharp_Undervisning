using BLL;
using DTOL.Model;
using GUI_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_GUI.Models;
using System.Diagnostics;

namespace GUI_MVC.Controllers
{
    public class HomeController : Controller
    {
        TidsSystemBLL tidsSystemBLL = new TidsSystemBLL();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var viewModel = new TidsregistreringViewModel
            {
                Medarbejdere = tidsSystemBLL.GetMedarbejdere()
                    .Select(m => new SelectListItem { Value = m.MedarbejderId.ToString(), Text = m.Navn }).ToList(),
                Afdelinger = tidsSystemBLL.GetAfdelinger()
                    .Select(a => new SelectListItem { Value = a.AfdelingId.ToString(), Text = a.Navn }).ToList(),
                Sager = tidsSystemBLL.GetSager()
                    .Select(s => new SelectListItem { Value = s.SagId.ToString(), Text = s.Beskrivelse }).ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Index(TidsregistreringViewModel model)
        {
            if (ModelState.IsValid)
            {
                var tidsregistrering = model.SagId.HasValue
                    ? new Tidsregistrering(model.StartTidspunkt, model.SlutTidspunkt, model.MedarbejderId, model.SagId.Value)
                    : new Tidsregistrering(model.StartTidspunkt, model.SlutTidspunkt, model.MedarbejderId);

                tidsSystemBLL.OpretTidsregistrering(tidsregistrering);

                TempData["Success"] = "Tidsregistreringen blev oprettet!";
            }

            model.Medarbejdere = tidsSystemBLL.GetMedarbejdere()
                .Select(m => new SelectListItem { Value = m.MedarbejderId.ToString(), Text = m.Navn }).ToList();
            model.Afdelinger = tidsSystemBLL.GetAfdelinger()
                .Select(a => new SelectListItem { Value = a.AfdelingId.ToString(), Text = a.Navn }).ToList();
            model.Sager = tidsSystemBLL.GetSager()
                .Select(s => new SelectListItem { Value = s.SagId.ToString(), Text = s.Beskrivelse }).ToList();

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() 
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
