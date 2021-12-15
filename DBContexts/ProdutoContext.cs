using LojaProdutos.Models;
using Microsoft.EntityFrameworkCore;

namespace LojaProdutos.SqliteDbContext
{
    public class ProdutoContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=LojaDb.db");

    }
}