using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.DAO.Interface
{
    internal interface ISelectCommandString<T> where T : class
    {
        public T getItemBySql(string sql, T filter);

        public List<T> getItensBySql(string sql, T filter);
    }
}
