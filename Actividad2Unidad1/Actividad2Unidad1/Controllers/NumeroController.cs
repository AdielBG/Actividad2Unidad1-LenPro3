using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace Actividad2Unidad1.Controllers
{
    public class NumeroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Verificar(int numero)
        {
            string mensaje;

            if (numero <= 1)
            {
                mensaje = "Debe ingresar un número mayor que 1.";
            }
            else
            {
                bool primo = true;
                for (int i = 2; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        primo = false;
                        break;
                    }
                }

                mensaje = primo
                    ? $"{numero} es un número primo."
                    : $"{numero} no es un número primo.";
            }

            ViewBag.Mensaje = mensaje;
            return View();

        }
    }

}
