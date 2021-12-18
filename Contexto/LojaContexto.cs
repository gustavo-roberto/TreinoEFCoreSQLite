using LojaProdutos.Models;
using Microsoft.EntityFrameworkCore;

namespace LojaProdutos.Contexto
{
    public class LojaContexto : DbContext
    {
        public DbSet<Produto> Produtos { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=LojaDb.db");

    }
}