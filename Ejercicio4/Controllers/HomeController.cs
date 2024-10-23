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

        /// <summary>
        /// Funcion que te envia a la vista index
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Funcion que te envia a la vista listado de una persona aleatoria
        /// </summary>
        /// <returns>Una lista de personas</returns>
        public IActionResult listadoPersonaRandom()
        {

            List<ClsPersona> listado = ClsListados.obtenerPersonas();
            return View(listado);
        }

        /// <summary>
        /// Funcion que te envia a la vista editar persona
        /// </summary>
        /// <returns>Persona aleatoria para editar en el formulario</returns>
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
