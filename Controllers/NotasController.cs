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

            int aprobados = 0;
            int reprobados = 0;

            foreach (double nota in datos.Notas)
            {
                if (nota >= 70)
                {
                    aprobados++;
                }
                else
                {
                    reprobados++;
                }
            }

            return Ok(new
            {
                promedio = Math.Round(promedio, 2),
                notaMayor = datos.Notas.Max(),
                notaMenor = datos.Notas.Min(),
                aprobados,
                reprobados
            });
        }
    }


    public class NotasRequest
    {
        public List<double> Notas { get; set; } = new List<double>();
    }
}


