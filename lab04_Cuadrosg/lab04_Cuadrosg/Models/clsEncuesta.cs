using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab04_Cuadrosg.Models
{
    public class clsEncuesta
    {
        public string alternativa1{get; set;}
        public string alternativa2{get; set;}
        public string alternativa3{get; set;}
        public string alternativa4{get; set;}
        public int votos1 { get; set; }
        public int votos2 { get; set; }
        public int votos3 { get; set; }
        public int votos4 { get; set; }

        public double porcentajeVotos1 { get; set; }
        public double porcentajeVotos2 { get; set; }
        public double porcentajeVotos3 { get; set; }
        public double porcentajeVotos4 { get; set; }

        public int TotalVotos { get; set; }

        public double porcentajeTotal { get; set; }
    }
}