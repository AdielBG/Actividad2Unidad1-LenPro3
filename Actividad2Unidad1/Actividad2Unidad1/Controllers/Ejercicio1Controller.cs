using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class Ejercicio1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Saludar(string nombre)
        {
            if (!string.IsNullOrWhiteSpace(nombre))
            {
                ViewBag.Mensaje = $"Hola, {nombre}, bienvenido a ASP.NET MVC.";
            }
            else
            {
                ViewBag.Mensaje = $"Hola extraño, tienes que ingresar tu nombre para ver la bienvenida.";
            }

            return View();
        }
    }
}
