using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticaParcial.Web.Entidades;
using PracticaParcial.Web.Models;
using PracticaParcial.Web.Servicios;

namespace PracticaParcial.Web.Controllers
{
    public class CalculadoraController : Controller
    {
        private IServiceCalculadora _serviceCalculadora;

        public CalculadoraController(IServiceCalculadora serviceCalculadora)
        {
            _serviceCalculadora = serviceCalculadora;

        }
        [HttpGet]
        public IActionResult Resultado()
        {
            var resultados = _serviceCalculadora.traerResultados();
            return View(resultados);
        }
        public IActionResult Sumar()
        {
            return View();
        }
        public IActionResult Restar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Sumar(SumarModel sumarModel)
        {
            var resultado = _serviceCalculadora.sumar(sumarModel.Numero1, sumarModel.Numero2);
            ViewData["ResultadoSuma"] = resultado;
            return RedirectToAction("Resultado");
        }
        [HttpPost]
        public IActionResult Restar(RestarModel restarModel)
        {
            var resultado = _serviceCalculadora.restar(restarModel.Numero1, restarModel.Numero2);
            ViewData["ResultadoResta"] = resultado;
            return RedirectToAction("Resultado");
        }

        public ActionResult Index()
        {
            return View();
        }

     
      
    }
}
