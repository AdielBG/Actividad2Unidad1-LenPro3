using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class CalculadoraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calcular(float num1, float num2, string operacion)
        {
            ViewBag.Num1 = num1;
            ViewBag.Num2 = num2;
            ViewBag.Operacion = operacion;
            ViewBag.Mensaje = "";


            switch (operacion)
            {
                case "sumar":

                    ViewBag.resultado = num1 + num2;

                    ViewBag.Mensaje = $"{num1} + {num2} es igual a {ViewBag.resultado}";
                    
                    break;

                case "restar":

                    ViewBag.resultado = num1 - num2;

                    ViewBag.Mensaje = $"{num1} - {num2} es igual a {ViewBag.resultado}";

                    break;

                case "multiplicar":

                    ViewBag.resultado = num1 * num2;

                    ViewBag.Mensaje = $"{num1} * {num2} es igual a {ViewBag.resultado}";

                    break;

                case "dividir":

                    ViewBag.resultado = num1 / num2;

                    ViewBag.Mensaje = $"{num1} / {num2} es igual a {ViewBag.resultado}";

                    break;

                default:
                    ViewBag.Mensaje = "Error de operacion";
                    break;

            }


            return View();
        }

    }
}
