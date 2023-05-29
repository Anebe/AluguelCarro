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
    public class ClienteDAO : IGenericDAO<Cliente>
    {
        private IDbConnection _dbConnection;
        private IMySqlStringFactory<Cliente> _sqlFactory;

        public ClienteDAO(IDbConnection dbConnection, IMySqlStringFactory<Cliente> sqlFactory)
        {
            _dbConnection = dbConnection;
            _sqlFactory = sqlFactory;
        }

        public bool Adicionar(Cliente item)
        {
            string sql = _sqlFactory.GetInsertSql("Id");
            int row = _dbConnection.Execute(sql, item);
            return row > 0 && row < 2;
        }

        public bool Atualizar(Cliente item)
        {
            string sql = _sqlFactory.GetUpdateSql("Id");
            int row = _dbConnection.Execute(sql, item);
            return row > 0 && row < 2;
        }

        public Cliente? BuscarUnico(Cliente item)
        {
            string sql = _sqlFactory.GetSelectSql();
            var cliente = _dbConnection.QuerySingle<Cliente>(sql, item);
            return cliente;
        }

        public List<Cliente> BuscarVarios()
        {
            string sql = _sqlFactory.GetSelectSql();
            var cliente = _dbConnection.Query<Cliente>(sql);
            return cliente.ToList();
        }

        public bool Remover(Cliente item)
        {
            string sql = _sqlFactory.GetDeleteSql("Id");
            int row = _dbConnection.Execute(sql, item);
            return row > 0 && row < 2;
        }
    }
}
