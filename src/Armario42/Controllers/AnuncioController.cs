using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Armario42.Models;

namespace Armario42.Controllers
{
    public class AnuncioController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public AnuncioController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            var anuncios = _context.Anuncios.ToList();
            return View(anuncios);
        }

        public IActionResult Create()
        {
            ViewBag.Lojas = new SelectList(_context.Lojas, "LojaId", "Nome");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Anuncio anuncio, IFormFile? Foto)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Lojas = new SelectList(_context.Lojas, "LojaId", "Nome");
                TempData["MensagemErro"] = "Dados inválidos. Verifique os campos e tente novamente.";
                return View(anuncio);
            }

            try
            {
                // Verifica e salva imagem, se houver
                if (Foto != null && Foto.Length > 0)
                {
                    var nomeArquivo = Path.GetFileName(Foto.FileName);
                    var caminhoPasta = Path.Combine(_env.WebRootPath ?? "wwwroot", "imagensAnuncios");
                    Directory.CreateDirectory(caminhoPasta);
                    var caminhoCompleto = Path.Combine(caminhoPasta, nomeArquivo);

                    using (var stream = new FileStream(caminhoCompleto, FileMode.Create))
                    {
                        Foto.CopyTo(stream);
                    }

                    anuncio.Foto = "/imagensAnuncios/" + nomeArquivo;
                }

                _context.Anuncios.Add(anuncio);
                _context.SaveChanges();

                TempData["MensagemSucesso"] = "Anúncio criado com sucesso!";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Lojas = new SelectList(_context.Lojas, "LojaId", "Nome");
                TempData["MensagemErro"] = "Erro ao salvar anúncio: " + ex.Message;
                return View(anuncio);
            }
        }

        public IActionResult Edit(int id)
        {
            var anuncio = _context.Anuncios.Find(id);
            if (anuncio == null)
            {
                return NotFound();
            }
            ViewBag.Lojas = new SelectList(_context.Lojas, "LojaId", "Nome", anuncio.LojaId);
            return View(anuncio);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Anuncio anuncio)
        {
            if (id != anuncio.AnuncioId)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(anuncio);
                _context.SaveChanges();
                TempData["MensagemSucesso"] = "Anúncio atualizado com sucesso!";
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Lojas = new SelectList(_context.Lojas, "LojaId", "Nome", anuncio.LojaId);
            TempData["MensagemErro"] = "Erro ao atualizar o anúncio. Verifique os dados.";
            return View(anuncio);
        }

        public IActionResult Delete(int id)
        {
            var anuncio = _context.Anuncios.Find(id);
            return anuncio == null ? NotFound() : View(anuncio);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var anuncio = _context.Anuncios.Find(id);
            if (anuncio != null)
            {
                _context.Anuncios.Remove(anuncio);
                _context.SaveChanges();
                TempData["MensagemSucesso"] = "Anúncio removido com sucesso!";
            }

            return RedirectToAction(nameof(Index));
        }
    }
}