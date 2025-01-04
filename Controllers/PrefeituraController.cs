using Microsoft.AspNetCore.Mvc;
using Prefeituras.Data;
using Prefeituras.Models;
using Prefeituras.Repository;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        public IActionResult ApagarConfirmacao(int id)
        {
            var list = _prefeituraRepository.BuscarPorId(id);
            return View(list);
        }
        public IActionResult Excluir(int id)
        {
            try
            {
                bool apagado = _prefeituraRepository.Apagar(id);
                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Cadastro apagado com sucesso!";
                }
                else
                {
                    TempData["MensagemErro"] = $"Ops, não conseguimos apagar seu contato!";
                }
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos apagar seu contato, mais detalhes do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Cadastrar(PrefeituraModel prefeitura)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _prefeituraRepository.Cadastrar(prefeitura);
                    TempData["MensagemSucesso"] = "Cadastro realizado com sucesso";
                    return RedirectToAction("Index");
                }

                return View(prefeitura);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar seu contato, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(PrefeituraModel prefeitura)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _prefeituraRepository.Editar(prefeitura);
                    TempData["MensagemSucesso"] = "Cadastro alterado com sucesso";
                    return RedirectToAction("Index");
                }
                return View(prefeitura);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos atualizar seu contato, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }       
    }
}
