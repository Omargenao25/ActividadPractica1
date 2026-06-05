using Microsoft.AspNetCore.Mvc;

namespace ActividadPractica1.Controllers
{
    [ApiController]
    [Route("api/texto")]
    public class TextoController : ControllerBase
    {
        [HttpGet("contar")]
        public IActionResult Contar(string texto)
        {
            int caracteres = texto.Length;

            string[] palabras = texto.Split(' ');

            int vocales = 0;

            foreach (char letra in texto.ToLower())
            {
                if (letra == 'a' ||
                    letra == 'e' ||
                    letra == 'i' ||
                    letra == 'o' ||
                    letra == 'u')
                {
                    vocales++;
                }
            }

            return Ok(new
            {
                palabras = palabras.Length,
                caracteres,
                vocales
            });
        }
    }
}
