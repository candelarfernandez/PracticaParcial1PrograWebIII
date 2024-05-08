namespace PracticaParcial.Web.Models
{
    public class RestarModel : CalculadoraModel
    {
        public RestarModel()
        {
        }
        public RestarModel(RestarModel restar) { 
        Numero1 = restar.Numero1;
        Numero2 = restar.Numero2;
        }
    
    }
}
