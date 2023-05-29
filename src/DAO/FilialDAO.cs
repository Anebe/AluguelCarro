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
    internal class FilialDAO : IFilialDAO
    {
        private IDbConnection _dbConnection;
        private IMySqlStringFactory<FilialDTO> _sqlFactory;

        public FilialDAO(IDbConnection dbConnection, IMySqlStringFactory<FilialDTO> sqlFactory)
        {
            _dbConnection = dbConnection;
            _sqlFactory = sqlFactory;
        }

        public bool Adicionar(FilialDTO item)
        {
            string sql = _sqlFactory.GetInsertSql();
            int row = _dbConnection.Execute(sql, item);
            return row > 0 && row < 2;
        }

        public bool Atualizar(FilialDTO item)
        {
            string sql = _sqlFactory.GetUpdateSql();
            int row = _dbConnection.Execute(sql, item);
            return row > 0 && row < 2;
        }

        public FilialDTO? BuscarUnico(FilialDTO item)
        {
            string sql = _sqlFactory.GetSelectSql();
            var filial = _dbConnection.QuerySingle<FilialDTO>(sql, item);
            return filial;
        }

        public List<FilialDTO> BuscarVarios()
        {
            string sql = _sqlFactory.GetSelectSql();
            var filial = _dbConnection.Query<FilialDTO>(sql);
            return filial.ToList();
        }

        public bool Remover(FilialDTO item)
        {
            string sql = _sqlFactory.GetDeleteSql("Id");
            int row = _dbConnection.Execute(sql, item);
            return row > 0 && row < 2;
        }
    }
}
