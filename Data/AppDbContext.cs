using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class AppDbContext : DbContext
    {
        // Construtor: recebe as opcoes de conexoes e serao usadas dentro do App e tem nome de options e como base options
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        // Tabelas
        public DbSet<AutorModel> Autores { get; set; }
        public DbSet<LivroModel> Livros { get; set; }
    }
}
