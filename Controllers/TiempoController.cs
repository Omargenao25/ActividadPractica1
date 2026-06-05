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

            string formato = $"{horas:D2}: {minutos:D2}:{segundosRestantes:D2}";

            return Ok(new
            {
                horas,
                minutos,
                segundos = segundosRestantes,
                formato
            });
        }
    }
}