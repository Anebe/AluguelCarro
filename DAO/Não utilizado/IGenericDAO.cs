using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.DAO
{
    public interface IGenericDAO<T>
    {
        public bool Adicionar(T item);
        public bool Atualizar(T item);
        public bool Remover(T item);
        public List<T> BuscarTodos();
        public T BuscarPorId(int id);
    }
}
