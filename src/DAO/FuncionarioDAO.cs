using AluguelCarro.src.DAO.Interface;
using AluguelCarro.src.DTO;
using AluguelCarro.src.Util;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.DAO
{
    internal class FuncionarioDAO : IFuncionarioDAO
    {
        private IDbConnection _dbConnection;
        private IMySqlStringFactory<FuncionarioDTO> _sqlFactory;

        public FuncionarioDAO(IDbConnection dbConnection, IMySqlStringFactory<FuncionarioDTO> sqlFactory)
        {
            _dbConnection = dbConnection;
            _sqlFactory = sqlFactory;
        }

        public bool Adicionar(FuncionarioDTO item)
        {
            string sql = _sqlFactory.GetInsertSql();
            int row = _dbConnection.Execute(sql, item);
            return row > 0 && row < 2;
        }

        public bool Atualizar(FuncionarioDTO item)
        {
            string sql = _sqlFactory.GetUpdateSql();
            int row = _dbConnection.Execute(sql, item);
            return row > 0 && row < 2;
        }

        public FuncionarioDTO? BuscarUnico(FuncionarioDTO item)
        {
            string sql = _sqlFactory.GetSelectSql();
            var funcionario = _dbConnection.QuerySingle<FuncionarioDTO>(sql, item);
            return funcionario;
        }

        public List<FuncionarioDTO> BuscarVarios()
        {
            string sql = _sqlFactory.GetSelectSql();
            var funcionario = _dbConnection.Query<FuncionarioDTO>(sql);
            return funcionario.ToList();
        }

        public bool Remover(FuncionarioDTO item)
        {
            string sql = _sqlFactory.GetDeleteSql("Id");
            int row = _dbConnection.Execute(sql, item);
            return row > 0 && row < 2;
        }
    }
}
