using Microsoft.AspNetCore.Mvc;
using Armario42.Models;
using System.Linq;

namespace Armario42.Controllers
{
    public class LoginController : Controller
    {
        private readonly AppDbContext _context;

        public LoginController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /Login
        public IActionResult Index()
        {
            return View();
        }

        // POST: /Login
        [HttpPost]
        public IActionResult Index(string email, string senha)
        {
            var usuario = _context.Usuarios.FirstOrDefault(u => u.Email == email);

            if (usuario == null)
            {
                TempData["MensagemErro"] = "Usuário não encontrado.";
                return View();
            }

            if (usuario.Senha != senha)
            {
                TempData["MensagemErro"] = "Senha incorreta.";
                return View();
            }

            TempData["MensagemSucesso"] = "Usuário logado com sucesso!";
            return RedirectToAction("Index", "Home");
        }

        // GET: /Login/EsqueciSenha
        public IActionResult EsqueciSenha()
        {
            return View();
        }

        // POST: /Login/EnviarEmailRecuperacao
        [HttpPost]
        public IActionResult EnviarEmailRecuperacao(string email)
        {
            var usuario = _context.Usuarios.FirstOrDefault(u => u.Email == email);

            if (usuario != null)
            {
                // Aqui você implementaria o envio de e-mail real
                // Exemplo: EmailService.EnviarRecuperacao(usuario.Email);
            }

            TempData["Mensagem"] = "Se o e-mail informado estiver cadastrado, enviaremos instruções para recuperação.";
            return RedirectToAction("Index");
        }
    }
}