using Demo_ASP_MVC_Intro.Data;
using Demo_ASP_MVC_Intro.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo_ASP_MVC_Intro.Controllers
{
    public class DuckController : Controller
    {
        public IActionResult Index()
        {
            int nb = (new Random()).Next(0, 43);

            // ViewData - Ajout de la clef "number"
            ViewData["Number"] = nb;

            // ViewBag - Ajout d'un message
            ViewBag.Message = "Message dans le controller !";

            return View();
        }

        public IActionResult List()
        {
            // Récuperation des données (Fake DB)
            IEnumerable<Duck> ducks = FakeDB.Ducks;

            // Utilisation du mecanisme de "Modele de Vue"
            return View(ducks);
        }

        public IActionResult Detail()
        {
            return View();
        }

        public IActionResult Demo()
        {
            // -> Pas de vue !!!
            return View();
        }
    }
}
