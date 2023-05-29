using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AluguelCarro.src.Util;
using AluguelCarro.src.DAO.Interface;
using AluguelCarro.src.DTO;

namespace AluguelCarro.src.DAO
{
    internal class AluguelDAO : IAluguelDAO
    {
        private IDbConnection _dbConnection;
        private IMySqlStringFactory<AluguelDTO> _sqlFactory;

        public AluguelDAO(IDbConnection dbConnection, IMySqlStringFactory<AluguelDTO> sqlFactory)
        {
            _dbConnection = dbConnection;
            _sqlFactory = sqlFactory;
        }

        public bool Adicionar(AluguelDTO item)
        {
            string sql = _sqlFactory.GetInsertSql("Id");
            int row = _dbConnection.Execute(sql, item);
            return row > 0 && row < 2;
        }

        public bool Atualizar(AluguelDTO item)
        {
            string sql = _sqlFactory.GetUpdateSql();
            int row = _dbConnection.Execute(sql, item);
            return row > 0 && row < 2;
        }

        public AluguelDTO? BuscarUnico(AluguelDTO item)
        {
            string sql = _sqlFactory.GetSelectSql();
            var aluguel = _dbConnection.QuerySingle<AluguelDTO>(sql, item);
            return aluguel;
        }

        public List<AluguelDTO> BuscarVarios()
        {
            string sql = _sqlFactory.GetSelectSql();
            var aluguel = _dbConnection.Query<AluguelDTO>(sql);
            return aluguel.ToList();
        }

        public bool Remover(AluguelDTO item)
        {
            string sql = _sqlFactory.GetDeleteSql("Id");
            int row = _dbConnection.Execute(sql, item);
            return row > 0 && row < 2;
        }
    }
}
