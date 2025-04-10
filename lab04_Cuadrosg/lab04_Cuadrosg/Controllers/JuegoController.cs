using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab04_Cuadrosg.Models;


namespace lab04_Cuadrosg.Controllers
{
    public class JuegoController : Controller
    {
        // GET: Juego
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Generar(clsJuego objJuego)
        {
            Random rnd = new Random();

            objJuego.numero1 = rnd.Next(3);
            objJuego.numero2 = rnd.Next(3);
            objJuego.numero3 = rnd.Next(3);

            if ((objJuego.numero1 == objJuego.numero2) &&
                (objJuego.numero2 == objJuego.numero3))
            {
                objJuego.resultado = "Ganaste S/. 1,500.00";
            }
            else if ((objJuego.numero1 == objJuego.numero2) ||
                     (objJuego.numero2 == objJuego.numero3) ||
                     (objJuego.numero1 == objJuego.numero3))
            {
                objJuego.resultado = "Ganaste un intento más";
            }
            else
            {
                objJuego.resultado = "Perdiste, sigue apostando para volverme más rico... :(";
            }

            return View(objJuego);
        }
    }
}