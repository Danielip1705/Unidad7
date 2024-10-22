using EjercicioUnidad7.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EjercicioUnidad7.Controllers
{
    public class HomeController : Controller
    {

        private List<ClsPersona> personas = new List<ClsPersona>()
            {
                new ClsPersona("Pablo", "Iglesias", 19),
                new ClsPersona("Enrique", "Florencio", 21),
                new ClsPersona("Patos", "Mas", 34),
                new ClsPersona("Felipe", "Ponzo", 93),
                new ClsPersona("Charizard", "Potis", 42),
                new ClsPersona("Mac", "Clovin", 29),
            };

        public IActionResult Index()
        {
            int hora = DateTime.Now.Hour;

            ViewBag.horaActual = hora.ToString(); // Mantienes la hora aqu�
            ViewBag.fechaActual = DateTime.Now.ToShortDateString(); // Mantienes la fecha aqu�

            if (hora >= 8 && hora < 12)
            {
                ViewData["Saludo"] = "Buenos d�as";
            }
            else if (hora >= 12 && hora < 20)
            {
                ViewData["Saludo"] = "Buenas tardes";
            }
            else
            {
                ViewData["Saludo"] = "Buenas noches";
            }

            ClsPersona persona = new("Daniel", "Iglesias", 19);

            return View(persona);
        }

        public ActionResult listadoPersonas()
        {


            return View(personas);

        }

        public ActionResult listadoPersonasPos3()
        {

            return View(personas);
        }
    }
}
