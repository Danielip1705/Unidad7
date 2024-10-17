using EjercicioUnidad7.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EjercicioUnidad7.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            int hora = DateTime.Now.Hour;
            ViewBag.hora = hora.ToString;
            if (hora > 8 && hora < 12)
            {
                ViewData["Saludo"] = "Buenos dias";
            }
            else if (hora > 12 && hora < 20)
            {
                ViewData["Saludo"] = "Buenas tardes";
            }
            else
            {
                ViewData["Saludo"] = "Buenas noches";
            }
            
            
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
    }
}
