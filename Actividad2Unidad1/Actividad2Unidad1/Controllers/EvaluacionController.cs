using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class EvaluacionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Resultado(int cali1, int cali2, int cali3, int cali4)
        {
            float promedio = (cali1 + cali2 + cali3 + cali4) / 4;
            

            if (promedio >= 70) {

                ViewBag.Mensaje = $"Su promedio es {promedio}. Aprobado";
            
            }
            else if (promedio >= 60 & promedio <= 69)
            {

                ViewBag.Mensaje = $"Su promedio es {promedio}. En recuperación";

            }

            else
            {

                ViewBag.Mensaje = $"Su promedio es {promedio}. Reprobado";

            }


            return View();
        }

    }
}
