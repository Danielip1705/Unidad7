using Ejercicio4.Models;
using Ejercicio4.Models.DAL;
using Ejercicio4.Models.ENTIDADES;
using Ejercicio4.Models.VM;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;

namespace Ejercicio4.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult listadoPersonaRandom()
        {

            List<ClsPersona> listado = ClsListados.obtenerPersonas();
            return View(listado);
        }

        public IActionResult editarPersona()
        {
            Random rnd = new Random();
            List<ClsPersona> listadoPersona = ClsListados.obtenerPersonas();
            int aleatorio = rnd .Next(0,listadoPersona.Count);
            ClsPersona personaElegida = listadoPersona[aleatorio];

            ViewBag.departamentos = ClsListados.obtenerDepartamentos();

            return View(personaElegida);
        }
    }
}
