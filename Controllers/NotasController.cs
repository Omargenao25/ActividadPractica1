using Microsoft.AspNetCore.Mvc;

namespace ActividadPractica1.Controllers
{
    public class NotasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
