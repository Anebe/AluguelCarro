using CloneAluguel.DAO.Interface;
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
    internal class FuncionarioDAO : IGenericDAO<Funcionario>
    {
        private IDbConnection _dbConnection;
        private IMySqlStringFactory<Funcionario> _sqlFactory;

        public FuncionarioDAO(IDbConnection dbConnection, IMySqlStringFactory<Funcionario> sqlFactory)
        {
            _dbConnection = dbConnection;
            _sqlFactory = sqlFactory;
        }

        public bool Adicionar(Funcionario item)
        {
            string sql = _sqlFactory.GetInsertSql();
            int row = _dbConnection.Execute(sql, item);
            return row > 0 && row < 2;
        }

        public bool Atualizar(Funcionario item)
        {
            string sql = _sqlFactory.GetUpdateSql();
            int row = _dbConnection.Execute(sql, item);
            return row > 0 && row < 2;
        }

        public Funcionario? BuscarUnico(Funcionario item)
        {
            string sql = _sqlFactory.GetSelectSql();
            var funcionario = _dbConnection.QuerySingle<Funcionario>(sql, item);
            return funcionario;
        }

        public List<Funcionario> BuscarVarios()
        {
            string sql = _sqlFactory.GetSelectSql();
            var funcionario = _dbConnection.Query<Funcionario>(sql);
            return funcionario.ToList();
        }

        public bool Remover(Funcionario item)
        {
            string sql = _sqlFactory.GetDeleteSql("Id");
            int row = _dbConnection.Execute(sql, item);
            return row > 0 && row < 2;
        }
    }
}
