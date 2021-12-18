using System;
using LojaProdutos.Models;
using LojaProdutos.EntityConfig;
using System.Linq;

namespace LojaProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            var produto = new Produto()
             { Id = 12,
               Nome = "Garrafa",
               Preco = 12.4
             };

            using(var repo = new LojaContext())
            {
                var produtos = repo.Produtos.ToList();

                foreach(var p in produtos)
                {
                    Console.WriteLine(p);
                }
            }
        }
    }
}
