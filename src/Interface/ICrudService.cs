using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.Interface
{
    internal interface ICrudService<T> where T : class
    {
        public bool Adicionar(T item);
        public bool Atualizar(T item);
        public bool Remover(int id);
        public List<T> Buscar();
        public T Buscar(int id);
    }
}
