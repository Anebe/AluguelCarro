using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.DAO
{
    internal interface IMySqlStringFactory<T>
    {
        public string GetInsertSql(T item, PropertyInfo exceptFor);

        public string GetUpdateSql(T item, PropertyInfo only);

        public string GetSelectSql(T item, PropertyInfo only);

        public string GetDeleteSql(T item, PropertyInfo only);


    }
}
