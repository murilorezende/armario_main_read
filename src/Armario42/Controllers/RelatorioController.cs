using Microsoft.AspNetCore.Mvc;
using Armario42.Models;

namespace Armario42.Controllers
{
    public class RelatorioController : Controller
    {
        private readonly AppDbContext _context;

        public RelatorioController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var relatorios = _context.Relatorios.ToList();
            return View(relatorios);
        }

        public IActionResult Gerar()
        {
            var relatorio = new Relatorio
            {
                GeradoEm = DateTime.Now,
                Anuncios = _context.Anuncios.ToList()
            };

            _context.Relatorios.Add(relatorio);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detalhes(int id)
        {
            var relatorio = _context.Relatorios
                .FirstOrDefault(r => r.RelatorioId == id);

            return relatorio == null ? NotFound() : View(relatorio);
        }
    }
}
