using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.DAO
{
    public interface IGenericDAO<T>
    {
        public bool adicionar(T item);
        public bool atualizar(T item);
        public bool remover(T item);
        public List<T> buscarTodos();
        public T buscarPorId(int id);
    }
}
