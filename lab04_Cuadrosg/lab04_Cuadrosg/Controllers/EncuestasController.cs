using lab04_Cuadrosg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static lab04_Cuadrosg.Models.clsAlternativa;

namespace lab04_Cuadrosg.Controllers
{
    public class EncuestasController : Controller
    {
        private clsEncuestas Encuesta;

        // GET: Encuestas

        public EncuestasController()
        {
            if (System.Web.HttpContext.Current.Session["encuesta"] == null)
            {
                Encuesta = new clsEncuestas();
                //Dedinir el titulo de la encuesta
                Encuesta.Titulo = "¿Cual es tu lenguaje de programacion favorito?";
                Encuesta.CantidadTotal = 0;
                Encuesta.Alternativa = new List<clsAlternativa>();

                //Definimos las alternativas de la pregunta
                clsAlternativa alternativa1 = new clsAlternativa();
                alternativa1.Titulo = "Visual Basic";
                alternativa1.Cantidad = 0;
                alternativa1.Porcentaje = 0;
                Encuesta.Alternativa.Add(alternativa1);

                clsAlternativa alternativa2 = new clsAlternativa();
                alternativa2.Titulo = "Visual Basic";
                alternativa2.Cantidad = 0;
                alternativa2.Porcentaje = 0;

                Encuesta.Alternativa.Add(alternativa2);
                clsAlternativa alternativa3 = new clsAlternativa();
                alternativa3.Titulo = "Visual Basic";
                alternativa3.Cantidad = 0;
                alternativa3.Porcentaje = 0;
                Encuesta.Alternativa.Add(alternativa3);


                clsAlternativa alternativa4 = new clsAlternativa();
                alternativa4.Titulo = "Visual Basic";
                alternativa4.Cantidad = 0;
                alternativa4.Porcentaje = 0;
                Encuesta.Alternativa.Add(alternativa4);

                System.Web.HttpContext.Current.Session["encuesta"] = Encuesta;
            }
            else
            {
                Encuesta = System.Web.HttpContext.Current.Session["encuesta"] as clsEncuestas;
            }
        }
        [HttpGet]
        public ActionResult Index(clsEncuesta encuesta)
        { 
             return View(Encuesta);
        }

        [HttpPost]
        public ActionResult Index()
        {
            int index = Int32.Parse(Request["index"].ToString());

            clsAlternativa altenativa = Encuesta.Alternativa[index];

            altenativa.Cantidad++;
            Encuesta.CantidadTotal = Encuesta.Alternativa.Sum(x => x.Cantidad);

            foreach (clsAlternativa alt in Encuesta.Alternativa)
            {
                alt.Porcentaje = alt.Cantidad * 100 / Encuesta.CantidadTotal;
            }

            System.Web.HttpContext.Current.Session["encuesta"] = Encuesta;
            return View(Encuesta);
        }
    }
}
