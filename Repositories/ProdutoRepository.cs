
using System.Collections.Generic;
using System.Linq;
using LojaDb.Repositories.Interfaces;
using LojaProdutos.Contexto;
using LojaProdutos.Models;

namespace LojaDb.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public ProdutoRepository(LojaContexto contexto) : base(contexto)
        {
        }
        public IEnumerable<Produto> BuscarProdutoPorNome(string nome)
        {
            return _contexto.Produtos.Where(x => x.Nome == nome);
        }
    }
}