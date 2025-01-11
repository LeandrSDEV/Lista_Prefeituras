using Microsoft.AspNetCore.Mvc;
using Prefeituras.Models;
using Prefeituras.Repository;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Prefeituras.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public LoginController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel) 
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (loginModel.Login == "adm123" && loginModel.Senha == "123456")
                    {
                        return RedirectToAction("Index", "Home");
                    }

                    TempData["MensagemErro"] = "Usuário e/ou senha inválido(s). Por favor tente novamente.";

                }

                return View("Index");
            }
            catch (Exception erro)
            {

                TempData["MensagemErro"] = $"Ops, não conseguimos realizar seu login, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");

            }
        }
    }
}
