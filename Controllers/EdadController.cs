using Microsoft.AspNetCore.Mvc;

namespace ActividadPractica1.Controllers
{
    [ApiController]
    [Route("api/edad")]
    public class EdadController : ControllerBase
    {
        [HttpGet("calcular")]
        public IActionResult Calcular(DateTime fechaNacimiento)
        {
            int edad = DateTime.Now.Year - fechaNacimiento.Year;

            if (fechaNacimiento.Date > DateTime.Now.AddYears(-edad))
            {
                edad--;
            }

            string signo = "";

            int dia = fechaNacimiento.Day;
            int mes = fechaNacimiento.Month;

            if ((mes == 3 && dia >= 21) || (mes == 4 && dia <= 19))
                signo = "Aries";
            else if ((mes == 4 && dia >= 20) || (mes == 5 && dia <= 20))
                signo = "Tauro";
            else if ((mes == 5 && dia >= 21) || (mes == 6 && dia <= 20))
                signo = "Geminis";
            else if ((mes == 6 && dia >= 21) || (mes == 7 && dia <= 22))
                signo = "Cancer";
            else if ((mes == 7 && dia >= 23) || (mes == 8 && dia <= 22))
                signo = "Leo";
            else if ((mes == 8 && dia >= 23) || (mes == 9 && dia <= 22))
                signo = "Virgo";
            else if ((mes == 9 && dia >= 23) || (mes == 10 && dia <= 22))
                signo = "Libra";
            else if ((mes == 10 && dia >= 23) || (mes == 11 && dia <= 21))
                signo = "Escorpio";
            else if ((mes == 11 && dia >= 22) || (mes == 12 && dia <= 21))
                signo = "Sagitario";
            else if ((mes == 12 && dia >= 22) || (mes == 1 && dia <= 19))
                signo = "Capricornio";
            else if ((mes == 1 && dia >= 20) || (mes == 2 && dia <= 18))
                signo = "Acuario";
            else
                signo = "Piscis";

            return Ok(new
            {
                edad,
                signo
            });

        }
    }
}
