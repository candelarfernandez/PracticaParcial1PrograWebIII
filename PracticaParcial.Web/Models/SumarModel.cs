namespace PracticaParcial.Web.Models
{
    public class SumarModel : CalculadoraModel
    {
        public SumarModel() { }
        public SumarModel(SumarModel sumar)
        {
            Numero1 = sumar.Numero1;
            Numero2 = sumar.Numero2;

        }
    }
}
