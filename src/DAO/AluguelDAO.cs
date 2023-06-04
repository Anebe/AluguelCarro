using Dapper;
using System.Data;
using AluguelCarro.src.Util;
using AluguelCarro.src.DAO.Interface;
using AluguelCarro.src.DTO;

namespace AluguelCarro.src.DAO
{
    internal class AluguelDAO : IAluguelDAO
    {
        private IDbConnection _dbConnection;
        private IMySqlStringFactory<Aluguel> _sqlFactory;

        public AluguelDAO(IDbConnection dbConnection, IMySqlStringFactory<Aluguel> sqlFactory)
        {
            _dbConnection = dbConnection;
            _sqlFactory = sqlFactory;
        }

        public bool Adicionar(Aluguel item)
        {
            string sql = _sqlFactory.GetInsertSql("Id");
            int row = _dbConnection.Execute(sql, item);
            return row > 0 && row < 2;
        }

        public bool Atualizar(Aluguel item)
        {
            string sql = _sqlFactory.GetUpdateSql();
            int row = _dbConnection.Execute(sql, item);
            return row > 0 && row < 2;
        }

        public Aluguel? BuscarUnico(Aluguel item)
        {
            string sql = _sqlFactory.GetSelectSql(new string[]{"Id"});
            var aluguel = _dbConnection.QuerySingle<Aluguel>(sql, item);
            return aluguel;
        }

        public List<Aluguel> BuscarVarios()
        {
            string sql = _sqlFactory.GetSelectSql();
            var aluguel = _dbConnection.Query<Aluguel>(sql);
            return aluguel.ToList();
        }
        public bool Remover(Aluguel item)
        {
            string sql = _sqlFactory.GetDeleteSql("Id");
            int row = _dbConnection.Execute(sql, item);
            return row > 0 && row < 2;
        }

        public Aluguel getItemBySql(string sql, Aluguel filter)
        {
            var aluguel = _dbConnection.QuerySingle<Aluguel>(sql, filter);
            return aluguel;
        }

        public List<Aluguel> getItensBySql(string sql, Aluguel filter)
        {
            var aluguel = _dbConnection.Query<Aluguel>(sql, filter);
            return aluguel.ToList();
        }

    }
}
