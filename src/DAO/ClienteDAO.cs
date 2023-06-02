using AluguelCarro.src.DAO.Interface;
using AluguelCarro.src.DTO;
using AluguelCarro.src.Util;
using Dapper;
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
            var atributesCondiction = getNotNullPropriety(item);
            string sql = _sqlFactory.GetSelectSql(atributesCondiction);
            var cliente = _dbConnection.QuerySingle<Cliente>(sql, item);
            return cliente;
        }

        public List<Cliente> BuscarVarios()
        {
            string sql = _sqlFactory.GetSelectSql();
            var cliente = _dbConnection.Query<Cliente>(sql);
            return cliente.ToList();
        }

        public Cliente getItemBySql(string sql, Cliente item)
        {
            var cliente = _dbConnection.QuerySingle<Cliente>(sql, item);
            return cliente;
        }

        public List<Cliente> getItensBySql(string sql, Cliente filter)
        {
            var cliente = _dbConnection.Query<Cliente>(sql,filter);
            return cliente.ToList();
        }

        public bool Remover(Cliente item)
        {
            string sql = _sqlFactory.GetDeleteSql("Id");
            int row = _dbConnection.Execute(sql, item);
            return row > 0 && row < 2;
        }

        private string[] getNotNullPropriety(Cliente cliente)
        {
            PropertyInfo[] properties = typeof(Cliente).GetProperties();

            Cliente comparar = new Cliente();
            var nonNullProperties = properties.Where(p => p.GetValue(cliente) != null && !p.GetValue(cliente).Equals(p.GetValue(comparar)));


            return nonNullProperties.Select(p => p.Name).ToArray();
        }
    }
}
