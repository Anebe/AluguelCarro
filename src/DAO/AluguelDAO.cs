using CloneAluguel.DAO.Interface;
using CloneAluguel.DTO;
using CloneAluguel.Entity;
using CloneAluguel.Util;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneAluguel.DAO
{
    internal class AluguelDAO : IGenericDAO<Aluguel>
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
            string sql = _sqlFactory.GetSelectSql();
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
    }
}
