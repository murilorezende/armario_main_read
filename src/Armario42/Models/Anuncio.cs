using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Armario42.Models
{
    public enum StatusAnuncio
    {
        Ativo,
        Inativo
    }

    public class Anuncio
    {
        [Key]
        public int AnuncioId { get; set; }

        [Required(ErrorMessage = "O título é obrigatório.")]
        [StringLength(100, ErrorMessage = "O título deve ter no máximo 100 caracteres.")]
        public string Titulo { get; set; } = string.Empty;

        [StringLength(500, ErrorMessage = "A descrição deve ter no máximo 500 caracteres.")]
        public string Descricao { get; set; } = string.Empty;

        [Display(Name = "Foto do Anúncio")]
        public string Foto { get; set; } = string.Empty;

        [Required(ErrorMessage = "O preço é obrigatório.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O preço deve ser maior que zero.")]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [StringLength(200, ErrorMessage = "As tags devem ter no máximo 200 caracteres.")]
        public string Tags { get; set; } = string.Empty;

        [Required(ErrorMessage = "O status do anúncio é obrigatório.")]
        [Display(Name = "Status")]
        public StatusAnuncio StatusAnuncio { get; set; }

        [Required(ErrorMessage = "O ID da loja é obrigatório.")]
        [Display(Name = "Loja")]
        public int LojaId { get; set; }

        [ForeignKey("LojaId")]
        public Loja? Loja { get; set; }
    }
}