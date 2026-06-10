using Microsoft.AspNetCore.Mvc;

namespace ActividadPractica1.Controllers
{
    [ApiController]
    [Route("api/notas")]
    public class NotasController : ControllerBase
    {
        [HttpPost("estadisticas")]
        public IActionResult Estadisticas(NotasRequest datos)
        {
            double promedio = datos.Notas.Average();

        }
    }
}
