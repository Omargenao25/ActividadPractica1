using Microsoft.AspNetCore.Mvc;

namespace ActividadPractica1.Controllers
{
    [ApiController]
    [Route("api/hola")]
    public class HolaController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }
    }
}
