using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial.Web.Entidades
{
    public class ResultadoOperacion
    {
        public string Operacion { get; set; }
        public int Operando1 { get; set; }
        public string Operador { get; set; }
        public int Operando2 { get; set; }
        public int Resultado { get; set; }
    }
}
