using Microsoft.AspNetCore.Mvc;
using Armario42.Models;

namespace Armario42.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly AppDbContext _context;

        public UsuarioController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var usuarios = _context.Usuarios.ToList();
            return View(usuarios);
        }

        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Usuario usuario)
        {
            if (_context == null)
            {
                TempData["MensagemErro"] = "Erro interno: conexão com o banco de dados não está disponível.";
                return View(usuario);
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var usuarioExistente = _context.Usuarios.FirstOrDefault(u => u.Email == usuario.Email);
                    if (usuarioExistente != null)
                    {
                        TempData["MensagemErro"] = "Já existe um usuário cadastrado com este e-mail.";
                        return View(usuario);
                    }

                    _context.Usuarios.Add(usuario);
                    _context.SaveChanges();
                    TempData["MensagemSucesso"] = "Usuário cadastrado com sucesso!";
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao salvar usuário: " + ex.Message);
                    TempData["MensagemErro"] = $"Erro ao salvar usuário: {ex.Message}";
                    return View(usuario);
                }
            }

            TempData["MensagemErro"] = "Dados inválidos. Por favor, corrija os erros no formulário e tente novamente.";
            return View(usuario);
        }

        public IActionResult Edit(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            return usuario == null ? NotFound() : View(usuario);
        }

        [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, Usuario usuario, IFormFile? foto)
    {
    if (id != usuario.UsuarioId) return NotFound();

    if (ModelState.IsValid)
        {
        // Busca o usuário atual no banco
        var usuarioExistente = _context.Usuarios.FirstOrDefault(u => u.UsuarioId == id);
        if (usuarioExistente == null) return NotFound();

        // Atualiza os campos básicos
        usuarioExistente.Nome = usuario.Nome;
        usuarioExistente.Email = usuario.Email;
        usuarioExistente.Senha = usuario.Senha;

        // Verifica se tem imagem nova
        if (foto != null && foto.Length > 0)
        {
            var nomeArquivo = Path.GetFileName(foto.FileName);
            var caminhoArquivo = Path.Combine("wwwroot/imagens", nomeArquivo);

            // Garante que a pasta exista
            Directory.CreateDirectory("wwwroot/imagens");

            using (var stream = new FileStream(caminhoArquivo, FileMode.Create))
            {
                foto.CopyTo(stream);
            }

            usuarioExistente.FotoPerfil = "/imagens/" + nomeArquivo;
        }

        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    return View(usuario);
}


        public IActionResult Delete(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            return usuario == null ? NotFound() : View(usuario);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
