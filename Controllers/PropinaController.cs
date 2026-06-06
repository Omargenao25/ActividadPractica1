using Microsoft.AspNetCore.Mvc;

namespace ActividadPractica1.Controllers
{
    [ApiController]
    [Route("api/propina")]
    public class PropinaController : ControllerBase
    {
        [HttpGet("calcular")]
        public IActionResult Calcular(decimal monto, decimal porcentaje)
        {
            decimal propina = monto * porcentaje / 100;

            decimal total = monto + propina;
        }
}
}
