using Microsoft.AspNetCore.Mvc;
using Prefeituras.Data;
using Prefeituras.Models;
using Prefeituras.Repository;

namespace Prefeituras.Controllers
{
    public class PrefeituraController : Controller
    {
        private readonly IPrefeituraRepository _prefeituraRepository;
        private readonly BancoContext _bancoContext;

        public PrefeituraController(IPrefeituraRepository prefeituraRepository, BancoContext bancoContext)
        {
            _prefeituraRepository = prefeituraRepository;
            _bancoContext = bancoContext;
        }

        public IActionResult Index()
        {
            var list = _prefeituraRepository.BuscarTodos();
            return View(list);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {   
            var list = _prefeituraRepository.BuscarPorId(id);
            return View(list);
        }

        [HttpPost]
        public IActionResult Cadastrar(PrefeituraModel prefeitura)
        {
            _prefeituraRepository.Cadastrar(prefeitura);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Editar(PrefeituraModel prefeitura)
        {
            _prefeituraRepository.Editar(prefeitura);
            return RedirectToAction("Index");
        }
    }
}
