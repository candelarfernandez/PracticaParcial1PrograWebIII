using PracticaParcial.Web.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial.Web.Servicios
{
    public interface IServiceCalculadora
    {
        public int sumar(int num1, int num2);
        public int restar(int num1, int num2);
        public void registrarResultado(string operacion, int operando1, string operador, int operando2, int resultado);
        public IEnumerable<ResultadoOperacion> traerResultados();
    }
    public class ServiceCalculadora : IServiceCalculadora
    {
        private List<ResultadoOperacion> _resultadoOperacion;

        public ServiceCalculadora() {
            _resultadoOperacion = new List<ResultadoOperacion>();
        }
        public void registrarResultado(string operacion, int operando1, string operador, int operando2, int resultado)
        {
            var resultadoOperacion = new ResultadoOperacion
            {
                Operacion = operacion,
                Operando1 = operando1,
                Operador = operador,
                Operando2 = operando2,
                Resultado = resultado
            };
            _resultadoOperacion.Add(resultadoOperacion);
        }
        public IEnumerable<ResultadoOperacion> traerResultados()
        {
            return _resultadoOperacion;
        }

        public int restar(int num1, int num2)
        {
            var resultado=0;
            if(num1 > 0 && num2 > 0)
            {
                resultado = num1 - num2;
                registrarResultado("Restar", num1, "-", num2, resultado);
            }
            return resultado;
        }

        public int sumar(int num1, int num2)
        {
            var resultado = 0;
            if (num1 > 0 && num2 > 0)
            {
                resultado = num1 + num2;
                registrarResultado("Sumar", num1, "+", num2, resultado);
            }
            return resultado;
        }
    }
}
