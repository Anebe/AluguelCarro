using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.Util
{
    public interface IGenericCRUD<T> where T : class
    {
        public bool Adicionar(T item);
        public bool Atualizar(T item);
        public bool Remover(T item);
        public T? BuscarUnico(T item);
        public List<T> BuscarVarios();
    }
}
