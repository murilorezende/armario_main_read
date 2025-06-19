using System.ComponentModel.DataAnnotations;

namespace Armario42.Models
{
    public class Relatorio
    {
        [Key]
        public int RelatorioId { get; set; }

        public DateTime GeradoEm { get; set; } = DateTime.Now;

        public List<Anuncio> Anuncios { get; set; } = new();
    }
}
