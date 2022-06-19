using Microsoft.AspNetCore.Mvc;
using ProjektZaliczeniowyDziekanat.DAL.Models;
using ProjektZaliczeniowyDziekanat.Interfaces;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ProjektZaliczeniowyDziekanat.Controllers
{
    public class WykladowcaController : Controller
    {
        private readonly IObslugaWykladowca obslugaWykladowca;

        public WykladowcaController(IObslugaWykladowca obslugaWykladowca)
        {
            this.obslugaWykladowca = obslugaWykladowca;
        }

        [HttpGet]
        [Route("Wykladowca/Home")]
        public async Task<IActionResult> Index()
        {
            Wykladowca wykladowca = await obslugaWykladowca.ZalogowanyWykladowcaAsync(HttpContext.Session.GetInt32("wykladowcaID"));

            if (wykladowca == null)
                return BadRequest();
            else
                return View(wykladowca);
        }

        [HttpGet]
        public async Task<IActionResult> PlanZajec()
        {
            Wykladowca ZalWykladowca = await obslugaWykladowca.ZalogowanyWykladowcaAsync(HttpContext.Session.GetInt32("wykladowcaID"));

            if (ZalWykladowca == null)
                return BadRequest();
            else
                return View(await obslugaWykladowca.WyswietlZajeciaAsync(ZalWykladowca));
        }

        [HttpGet]
        public async Task<IActionResult> Dane()
        {
            WykladowcaDTO ZalWykladowca = await obslugaWykladowca.ZalogowanyWykladowcaDTOAsync(HttpContext.Session.GetInt32("wykladowcaID"));

            if (ZalWykladowca == null)
                return BadRequest();
            else
                return View(ZalWykladowca);
        }

        [HttpGet]
        public async Task<IActionResult> Contact()
        {
            var wykladowca = await obslugaWykladowca.ZalogowanyWykladowcaAsync(HttpContext.Session.GetInt32("wykladowcaID"));
            ViewData["nadawca"] = $"{wykladowca.Imie} {wykladowca.Nazwisko}";
            return View();
        }

    }
}
