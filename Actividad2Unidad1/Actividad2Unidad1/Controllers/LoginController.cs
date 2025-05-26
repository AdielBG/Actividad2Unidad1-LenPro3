using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Verificar(string usuario, string contraseña)
        {
           

            if(usuario == "admin")
            {
                if (contraseña == "123456")
                {
                    ViewBag.Mensaje = "Bienvenido";
                }
                else
                {
                    ViewBag.Mensaje = "Contraseña incorrecta";
                }
            }
            else
            {
                ViewBag.Mensaje = "Usuario incorrecto";
            }


            return View();
        }

    }
}
