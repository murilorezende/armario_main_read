using Microsoft.EntityFrameworkCore;

namespace Armario42.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // DbSets representam as tabelas do banco de dados
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Loja> Lojas { get; set; }
        public DbSet<Anuncio> Anuncios { get; set; }
        public DbSet<Relatorio> Relatorios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Chaves primárias explícitas (útil para evitar erros com PostgreSQL)
            modelBuilder.Entity<Usuario>().HasKey(u => u.UsuarioId);
            modelBuilder.Entity<Loja>().HasKey(l => l.LojaId);
            modelBuilder.Entity<Anuncio>().HasKey(a => a.AnuncioId);
            modelBuilder.Entity<Relatorio>().HasKey(r => r.RelatorioId);

            // Exemplo de função customizada (caso deseje usar funções SQL)
            // modelBuilder.HasDbFunction(() => MinhaFuncaoSqlExemplo(default)).HasName("nome_funcao_sql");
        }

        // Exemplo de função customizada (descomente e adapte se necessário)
        // public static int MinhaFuncaoSqlExemplo(int parametro) => throw new NotImplementedException();
    }
}