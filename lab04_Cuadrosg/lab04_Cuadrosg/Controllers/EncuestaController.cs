using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab04_Cuadrosg.Models;

namespace lab04_Cuadrosg.Controllers
{
    public class EncuestaController : Controller
    {
        // GET: Encuesta
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RealizarEncuesta(clsEncuesta objEncuesta)
        {
            ViewBag.Alternativa1 = "PHP";
            ViewBag.Alternativa2 = "C#";
            ViewData["Alternativa3"] = "Java";
            ViewData["Alternativa4"] = "Python";

            objEncuesta.votos1 = 0;
            objEncuesta.votos2 = 0;
            objEncuesta.votos3 = 0;
            objEncuesta.votos4 = 0;
            objEncuesta.TotalVotos = 0;

            objEncuesta.porcentajeVotos1 = 0.0d;
            objEncuesta.porcentajeVotos2 = 0.0d;
            objEncuesta.porcentajeVotos3 = 0.0d;
            objEncuesta.porcentajeVotos4 = 0.0d;
            objEncuesta.porcentajeTotal = 0.0d;

            if (Request["Curso"] == "Curso 1")
            {
                int contador = 0;
                if (Session["cv1"] == null)
                {
                    Session["cv1"] = 1;
                }
                else
                {
                    contador = Convert.ToInt32(Session["cv1"]);
                    contador++;
                    Session["cv1"] = contador;
                    objEncuesta.TotalVotos += contador;
                }
            }

            if (Request["Curso"] == "Curso 2")
            {
                int contador = 0;
                if (Session["cv2"] == null)
                {
                    Session["cv2"] = 1;
                }
                else
                {
                    contador = Convert.ToInt32(Session["cv2"]);
                    contador++;
                    Session["cv2"] = contador;
                    objEncuesta.TotalVotos += contador;
                }
            }

            if (Request["Curso"] == "Curso 3")
            {
                int contador = 0;
                if (Session["cv3"] == null)
                {
                    Session["cv3"] = 1;
                }
                else
                {
                    contador = Convert.ToInt32(Session["cv3"]);
                    contador++;
                    Session["cv3"] = contador;
                    objEncuesta.TotalVotos += contador;
                }
            }
            if (Request["Curso"] == "Curso 4")
            {
                int contador = 0;
                if (Session["cv4"] == null)
                {
                    Session["cv4"] = 1;
                }
                else
                {
                    contador = Convert.ToInt32(Session["cv4"]);
                    contador++;
                    Session["cv4"] = contador;
                    objEncuesta.TotalVotos += Convert.ToInt32(Session["cv4"]);
                }
            }

            Session["totalvotos"] = (Convert.ToInt32(Session["cv1"])
             + Convert.ToInt32(Session["cv2"]) + Convert.ToInt32(Session["cv3"])
             + Convert.ToInt32(Session["cv4"]));


            Session["porcentajeC1"] = ((Convert.ToDouble(Session["cv1"]) * 100.0d) /
                Convert.ToDouble(Session["totalvotos"])).ToString("0.00");

            Session["vp1"] = Convert.ToDouble(Session["porcentajeC1"]).ToString("0.00");


            Session["porcentajeC2"] = ((Convert.ToDouble(Session["cv2"]) * 100.0d) /
                Convert.ToDouble(Session["totalvotos"])).ToString("0.00");

            Session["vp2"] = Convert.ToDouble(Session["porcentajeC2"]).ToString("0.00");


            Session["porcentajeC3"] = ((Convert.ToDouble(Session["cv3"]) * 100.0d) /
                Convert.ToDouble(Session["totalvotos"])).ToString("0.00");

            Session["vp3"] = Convert.ToDouble(Session["porcentajeC3"]).ToString("0.00");


            Session["porcentajeC4"] = ((Convert.ToDouble(Session["cv4"]) * 100.0d) /
                Convert.ToDouble(Session["totalvotos"])).ToString("0.00");

            Session["vp4"] = Convert.ToDouble(Session["porcentajeC4"]).ToString("0.00");


            Session["totalPorcentaje"] = (Convert.ToDouble(Session["porcentajeC1"]) + Convert.ToDouble(Session["porcentajeC2"]) + Convert.ToDouble(Session["porcentajeC3"]) + Convert.ToDouble(Session["porcentajeC4"])).ToString("0");


            return View(objEncuesta);
        }
    }
}