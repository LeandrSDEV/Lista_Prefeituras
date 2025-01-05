using Microsoft.AspNetCore.Mvc;

namespace Prefeituras.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
