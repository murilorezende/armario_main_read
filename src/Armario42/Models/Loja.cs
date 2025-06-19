using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Armario42.Models
{
    public class Loja
    {
        [Key]
        public int LojaId { get; set; }

        [Required(ErrorMessage = "O nome da loja é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "O contato é obrigatório.")]
        [StringLength(100, ErrorMessage = "O contato deve ter no máximo 100 caracteres.")]
        public string Contato { get; set; } = string.Empty;

        // Relacionamento 1:N com Anuncio
        public ICollection<Anuncio>? Anuncios { get; set; }

        // Chave estrangeira para o usuário dono da loja
        [Required(ErrorMessage = "O ID do usuário é obrigatório.")]
        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario? Usuario { get; set; }
    }
}