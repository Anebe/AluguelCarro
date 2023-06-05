using AluguelCarro.src.DAO.Interface;
using AluguelCarro.src.DTO;
using AluguelCarro.src.Util;
using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.DAO
{
    public class ClienteDAO : IClienteDAO
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
            try
            {
                string sql = _sqlFactory.GetInsertSql("Id");
                int row = _dbConnection.Execute(sql, item);
                return row > 0 && row < 2;
            } catch (MySqlException e)
            {
                if(e.Number == 1062)// cpf duplicado
                {
                    throw new Exception("Cpf já cadastrado por outro Cliente!");
                }
            }
            return false;
        }

        public bool Atualizar(Cliente item)
        {
            string sql = _sqlFactory.GetUpdateSql("Id");
            int row = _dbConnection.Execute(sql, item);
            return row > 0 && row < 2;
        }

        public Cliente? BuscarUnico(Cliente item)
        {
            try
            {
                var atributesCondiction = _sqlFactory.getNotNullPropriety(item);
                string sql = _sqlFactory.GetSelectSql(atributesCondiction);
                var cliente = _dbConnection.QuerySingle<Cliente>(sql, item);
                return cliente;
            }
            catch (InvalidOperationException)
            {
                throw new Exception("Nenhum cliente encontrado.");
            }
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
