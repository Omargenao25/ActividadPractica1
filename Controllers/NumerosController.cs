using Microsoft.AspNetCore.Mvc;

namespace ActividadPractica1.Controllers
{
    [ApiController]
    [Route("api/numeros")]
    public class NumerosController : Controller
    {
        [HttpGet("analizar")]
        public IActionResult Analizar([FromQuery] int n)
        {
            return Ok(new
            {
                numero = n,
                parOimpar = n % 2 == 0 ? "Par" : "Impar",
                esPrimo = EsPrimo(n),
                signo = n > 0 ? "Positivo" : n < 0 ? "Negativo" : "Cero"
            });
        }

        private static bool EsPrimo(int numero)
        {
            if (numero < 2)
            {
                return false;
            }

            for (var divisor = 2; divisor <= Math.Sqrt(numero); divisor++)
            {
                if (numero % divisor == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
