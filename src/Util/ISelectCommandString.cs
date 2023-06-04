using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.Util
{
    internal interface ISelectCommandString
    {
        public T getItemBySql<T>(string sql, T filter);

        public List<T> getItensBySql<T>(string sql, T filter);
    }
}
