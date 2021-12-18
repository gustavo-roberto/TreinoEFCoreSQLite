
using System.Collections.Generic;
using System.Linq;
using LojaDb.Repositories.Interfaces;
using LojaProdutos.Contexto;

namespace LojaDb.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public readonly LojaContexto _contexto;

        public RepositoryBase(LojaContexto contexto)
        {
            _contexto = contexto;
        }

        public void Adicionar(T obj)
        {
            _contexto.Set<T>().Add(obj);
        }

        public void Atualizar(T obj)
        {
            _contexto.Set<T>().Update(obj);
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }

        public List<T> Listar(T obj)
        {
            return _contexto.Set<T>().ToList();
        }

        public void Remover(T obj)
        {
            _contexto.Set<T>().Remove(obj);
        }
    }
}