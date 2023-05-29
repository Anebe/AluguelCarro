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
    public class ClienteDAO : IClienteDAO
    {
        private IDbConnection _dbConnection;
        private IMySqlStringFactory<ClienteDTO> _sqlFactory;

        public ClienteDAO(IDbConnection dbConnection, IMySqlStringFactory<ClienteDTO> sqlFactory)
        {
            _dbConnection = dbConnection;
            _sqlFactory = sqlFactory;
        }

        public bool Adicionar(ClienteDTO item)
        {
            string sql = _sqlFactory.GetInsertSql("Id");
            int row = _dbConnection.Execute(sql, item);
            return row > 0 && row < 2;
        }

        public bool Atualizar(ClienteDTO item)
        {
            string sql = _sqlFactory.GetUpdateSql("Id");
            int row = _dbConnection.Execute(sql, item);
            return row > 0 && row < 2;
        }

        public ClienteDTO? BuscarUnico(ClienteDTO item)
        {
            string sql = _sqlFactory.GetSelectSql();
            var cliente = _dbConnection.QuerySingle<ClienteDTO>(sql, item);
            return cliente;
        }

        public List<ClienteDTO> BuscarVarios()
        {
            string sql = _sqlFactory.GetSelectSql();
            var cliente = _dbConnection.Query<ClienteDTO>(sql);
            return cliente.ToList();
        }

        public bool Remover(ClienteDTO item)
        {
            string sql = _sqlFactory.GetDeleteSql("Id");
            int row = _dbConnection.Execute(sql, item);
            return row > 0 && row < 2;
        }
    }
}
