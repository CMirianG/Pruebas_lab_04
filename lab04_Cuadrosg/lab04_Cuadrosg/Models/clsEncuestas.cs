using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace lab04_Cuadrosg.Models
{
    public class clsEncuestas
    {
        public string Titulo { get; set; }
        public int CantidadTotal { get; set; }

        public List<clsAlternativa> Alternativa { get; set; }
    


            

    }
       
}