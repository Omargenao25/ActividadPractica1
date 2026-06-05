using Microsoft.AspNetCore.Mvc;

namespace ActividadPractica1.Controllers
{
    [ApiController]
    [Route("api/imc")]
    public class ImcController : ControllerBase
    {
        [HttpGet("calcular")]
        public IActionResult Calcular(double peso, double altura)
        {
            double imc = peso / (altura * altura);

            string categoria;
            



            
        }
    }
}
