using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class NumeroPerfectoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Verificar(int numero)
        {
            int suma = 0;

            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                    suma += i;
            }

            string mensaje = (suma == numero)
                ? $"{numero} es un número perfecto."
                : $"{numero} no es un número perfecto.";

            ViewBag.Mensaje = mensaje;
            return View();
        }

    }
}
