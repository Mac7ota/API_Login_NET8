using Microsoft.EntityFrameworkCore;

namespace Contexto.Contexto
{
    public class AppDbContext : DbContext
    {
        public DbSet<Dominio.Autenticacao.Usuario> Users { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


    }
}
