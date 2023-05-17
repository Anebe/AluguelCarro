using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.DAO
{
    public class GenericDAO<T> : IGenericDAO<T>
    {
        private IDbConnection connectionDB;

        public GenericDAO(IDbConnection connectionDB)
        {
            this.connectionDB = connectionDB;
        }
        
        public bool adicionar(T item)
        {
            getTableName(item);
            getColunmNames(item);
            return false;
        }

        public bool atualizar(T item)
        {
            throw new NotImplementedException();
        }

        public T buscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> buscarTodos()
        {
            throw new NotImplementedException();
        }

        public bool remover(T item)
        {
            throw new NotImplementedException();
        }

        private string getTableName(T item)
        {
            Type type = typeof(T);
            Debug.WriteLine(type.Name);
            return type.Name;
        }

        private List<string> getColunmNames(T item)
        {
            Type type = typeof(T);
            Debug.WriteLine(type.GetProperties()[0].ToString());
            throw new NotImplementedException();
        }
    }
}
