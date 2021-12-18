
using System;
using System.Collections.Generic;

namespace LojaDb.Repositories.Interfaces
{
    public interface IRepositoryBase<T> : IDisposable where T : class
    {
        List<T> Listar(T obj);
        void Atualizar(T obj);
        void Remover(T obj);
        void Adicionar(T obj);        
    }
}