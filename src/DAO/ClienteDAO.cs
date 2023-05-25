using AluguelCarro.DAO;
using AluguelCarro.src.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic;
using MySqlConnector;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Reflection;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using AluguelCarro.src.Entity;

namespace AluguelCarro.src.DAO
{
    public class ClienteDAO : IClienteDAO
    {
        //private IDbConnection _connectionDB;
        //private MySqlStringFactory<Cliente> _sqlFactory;
        private MySqlContext _dbContext;

        public ClienteDAO()
        {
            //_connectionDB = connectionDB;
            //_sqlFactory = new MySqlStringFactory<Cliente>();
            _dbContext = new MySqlContext();
        }

        public List<Cliente> getClientesInativos(DateTime desdeDe)
        {
            List<Cliente> clientes = _dbContext.Aluguel
                                    .GroupBy(a => a.Cliente)
                                    .Select(g => new
                                    {
                                        Cliente = g.Key,
                                        DataFimMaisAlta = g.Max(a => a.DataFim )
                                    })
                                    .Where(x => x.DataFimMaisAlta < desdeDe)
                                    .Select(x => x.Cliente)
                                    .ToList();

            return clientes;
        }

        /*public bool Adicionar(Cliente cliente)
        {
            string sql;
            int rowAffect;
            try
            {
                //PropertyInfo? excetoId = cliente.GetType().GetProperty("Id");
                sql = sqlFactory.GetInsertSql("Id");

                rowAffect = connectionDB.Execute(sql, cliente);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
            return rowAffect > 0;
        }*/

        /*public bool Adicionar(Cliente cliente)
        {
            GenericDAO<Cliente> teste = new(_connectionDB, _sqlFactory);
            try
            {
                return teste.Adicionar(cliente);
            }
            catch (Exception)
            {
                throw;
            }
        }
        */

        /*public Cliente Buscar(int id)
        {
            Cliente result;

            try
            {
                //PropertyInfo? attributeCondiction = typeof(Cliente).GetProperty("Id");
                string sql = _sqlFactory.GetSelectSql("Id");
                result = _connectionDB.QuerySingle<Cliente>(sql, new {Id = id});
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }

            return result;
        }
        */

        /*public List<Cliente> Buscar()
        {
            try
            {
                string sql = _sqlFactory.GetSelectSql();
                return _connectionDB.Query<Cliente>(sql).ToList();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }*/

        /*public bool Atualizar(Cliente cliente)
        {
            string sql;
            int rowAffect;
            try
            {
                //PropertyInfo? attribute = cliente.GetType().GetProperty("Id");
                sql = _sqlFactory.GetUpdateSql("Id");

                rowAffect = _connectionDB.Execute(sql, cliente);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
            return rowAffect > 0;
        }*/

        /*public bool Remover(int id)
        {
            int rowAffect;
            try
            {
                string sql = _sqlFactory.GetDeleteSql("Id");
                rowAffect = _connectionDB.Execute(sql, new {Id = id});
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
                throw;
            }
            return rowAffect > 0;
        }
        */
    }
}
