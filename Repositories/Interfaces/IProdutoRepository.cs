
using System.Collections.Generic;
using LojaProdutos.Models;

namespace LojaDb.Repositories.Interfaces
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarProdutoPorNome(string nome);
    }
}