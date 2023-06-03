using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.Util
{
    public interface IMySqlStringFactory<T>
    {
        public string GetInsertSql(string? exceptFor = null);

        public string GetSelectSql(string[]? attributesCondition = null);

        public string GetUpdateSql(string? attributesCondition = null);

        public string GetDeleteSql(string attributesCondition);

        public string[] getNotNullPropriety(T item);
    }
}
