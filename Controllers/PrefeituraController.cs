using Microsoft.AspNetCore.Mvc;

namespace Prefeituras.Controllers
{
    public class PrefeituraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
