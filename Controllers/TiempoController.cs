using Microsoft.AspNetCore.Mvc;

namespace ActividadPractica1.Controllers
{
    [ApiController]
    [Route("api/tiempo")]
    public class TiempoController : ControllerBase
    {
        [HttpGet("formatear")]
        public IActionResult Formatear(int segundos)
        {
            int horas = segundos / 3600;

            int minutos = (segundos % 3600) / 60;

            int segundosRestantes = segundos % 60;

         
        }
    }
}