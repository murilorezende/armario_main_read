using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Armario42.Models;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace Armario42.Controllers
{
    public class LojaController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ILogger<LojaController> _logger;

        public LojaController(AppDbContext context, ILogger<LojaController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var lojas = _context.Lojas.ToList();
            return View(lojas);
        }

        public IActionResult Create()
        {
            ViewBag.Usuarios = new SelectList(_context.Usuarios, "UsuarioId", "Nome");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Loja loja)
        {
            _logger.LogInformation("Tentando criar loja: Nome={Nome}, Contato={Contato}, UsuarioId={UsuarioId}", 
                loja.Nome, loja.Contato, loja.UsuarioId);

            if (!ModelState.IsValid)
            {
                ViewBag.Usuarios = new SelectList(_context.Usuarios, "UsuarioId", "Nome");
                
                // Coletar todas as mensagens de erro
                var erros = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToList();
                
                var mensagemErro = "Dados inválidos: " + string.Join(", ", erros);
                _logger.LogWarning("Erro de validação: {Mensagem}", mensagemErro);
                
                TempData["MensagemErro"] = mensagemErro;
                return View(loja);
            }

            try
            {
                _context.Lojas.Add(loja);
                _context.SaveChanges();
                _logger.LogInformation("Loja criada com sucesso: ID={LojaId}", loja.LojaId);
                TempData["MensagemSucesso"] = "Loja cadastrada com sucesso!";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao salvar loja");
                ViewBag.Usuarios = new SelectList(_context.Usuarios, "UsuarioId", "Nome");
                TempData["MensagemErro"] = "Erro ao salvar loja: " + ex.Message;
                return View(loja);
            }
        }

        public IActionResult Edit(int id)
        {
            var loja = _context.Lojas.Find(id);
            if (loja == null)
            {
                return NotFound();
            }
            ViewBag.Usuarios = new SelectList(_context.Usuarios, "UsuarioId", "Nome", loja.UsuarioId);
            return View(loja);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Loja loja)
        {
            if (id != loja.LojaId)
                return NotFound();

            if (!ModelState.IsValid)
            {
                ViewBag.Usuarios = new SelectList(_context.Usuarios, "UsuarioId", "Nome", loja.UsuarioId);
                TempData["MensagemErro"] = "Dados inválidos. Verifique os campos e tente novamente.";
                return View(loja);
            }

            try
            {
                _context.Update(loja);
                _context.SaveChanges();
                TempData["MensagemSucesso"] = "Loja atualizada com sucesso!";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Usuarios = new SelectList(_context.Usuarios, "UsuarioId", "Nome", loja.UsuarioId);
                TempData["MensagemErro"] = "Erro ao atualizar loja: " + ex.Message;
                return View(loja);
            }
        }

        public IActionResult Delete(int id)
        {
            var loja = _context.Lojas.Find(id);
            return loja == null ? NotFound() : View(loja);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var loja = _context.Lojas.Find(id);
            if (loja != null)
            {
                try
                {
                    _context.Lojas.Remove(loja);
                    _context.SaveChanges();
                    TempData["MensagemSucesso"] = "Loja removida com sucesso!";
                }
                catch (Exception ex)
                {
                    TempData["MensagemErro"] = "Erro ao remover loja: " + ex.Message;
                }
            }
            else
            {
                TempData["MensagemErro"] = "Loja não encontrada.";
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            var loja = _context.Lojas
                .Include(l => l.Anuncios)
                .FirstOrDefault(l => l.LojaId == id);

            if (loja == null)
            {
                return NotFound();
            }

            return View(loja);
        }
    }
}