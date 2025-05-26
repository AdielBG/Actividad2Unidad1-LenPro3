using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class MonedaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Convertir(decimal monto, string divisa)
        {
            decimal resultado = 0;
            string mensaje = "";

            if (monto <= 0)
            {
                mensaje = "Por favor, ingrese un monto válido mayor que cero.";
            }
            else
            {
                switch (divisa)
                {
                    case "USD":
                        resultado = monto / 58;
                        mensaje = $"{monto} DOP = {resultado:F2} USD";
                        break;
                    case "EUR":
                        resultado = monto / 63;
                        mensaje = $"{monto} DOP = {resultado:F2} EUR";
                        break;
                    default:
                        mensaje = "Divisa no válida.";
                        break;
                }
            }

            ViewBag.Mensaje = mensaje;
            return View();
        }

    }
}
