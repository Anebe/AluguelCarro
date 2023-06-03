using AluguelCarro.src.DTO;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.Util
{
    internal class SelectCommandString : ISelectCommandString
    {

        private IDbConnection _dbConnection;

        public SelectCommandString(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public T getItemBySql<T>(string sql, T filter)
        {
            var item = _dbConnection.QuerySingle<T>(sql, filter);
            return item;
        }

        public List<T> getItensBySql<T>(string sql, T filter)
        {
            var item = _dbConnection.Query<T>(sql, filter);
            return item.ToList();
        }

    }
}
