using System.ComponentModel.DataAnnotations;

namespace PracticaParcial.Web.Models
{
    public class CalculadoraModel
    {
        [Range(0, 1000, ErrorMessage = "El número debe estar en el rango de 0 a 1000")]
        [Required(ErrorMessage = "¡Es obligatorio ingresar un numero!")]
        public int Numero1 { get; set; }
        [Range(0, 1000, ErrorMessage = "El número debe estar en el rango de 0 a 1000")]
        [Required(ErrorMessage = "¡Es obligatorio ingresar un numero!")]
        public int Numero2 { get; set; }
    }
}
