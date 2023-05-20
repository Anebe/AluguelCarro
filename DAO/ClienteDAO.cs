using AluguelCarro.DTO;
using Dapper;
using Microsoft.VisualBasic;
using MySqlConnector;
using System.Data;
using System.Diagnostics;
using System.Reflection;

namespace AluguelCarro.DAO
{
    public class ClienteDAO
    {
        private MySqlConnection connectionDB;
        private MySqlStringFactory<Cliente> sqlFactory;
        public ClienteDAO(MySqlConnection connectionDB)
        {
            this.connectionDB = connectionDB;
            sqlFactory = new MySqlStringFactory<Cliente>();
        }

        /*
        public bool AdicionarCliente(Cliente cliente)
        {
            int rowAffect = 0;
            var sql =   "insert into cliente(Nome, Cpf , Cnh , DtNascimento, Email, Rg, Telefone, Renach)" +
                        "values (@nome, @cpf, @CNH, @dtNascimento, @email, @rg, @telefone, @renach)";

            MySqlCommand comandoSql = new MySqlCommand(sql, connectionDB);

            comandoSql.Parameters.AddWithValue("@nome", cliente.Nome);
            comandoSql.Parameters.AddWithValue("@cpf", cliente.Cpf);
            comandoSql.Parameters.AddWithValue("@CNH", cliente.Cnh);
            comandoSql.Parameters.AddWithValue("@dtNascimento", cliente.DtNascimento);
            comandoSql.Parameters.AddWithValue("@email", cliente.Email);
            comandoSql.Parameters.AddWithValue("@rg", cliente.Rg);
            comandoSql.Parameters.AddWithValue("@telefone", cliente.Telefone);
            comandoSql.Parameters.AddWithValue("@renach", cliente.Renach);

            
            try
            {
                connectionDB.Open();
                rowAffect = connectionDB.Execute(sql, cliente);
                //comandoSql.Prepare();
                //rowAffect = comandoSql.ExecuteNonQuery();
                connectionDB.Close();
            }catch(Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
            return rowAffect > 0;
        }
        */

        public bool Adicionar(Cliente cliente)
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
        }

        public Cliente BuscarPorId(int id)
        {
            Cliente result;

            try
            {
                //PropertyInfo? attributeCondiction = typeof(Cliente).GetProperty("Id");
                string sql = sqlFactory.GetSelectSql("Id");
                result = connectionDB.QuerySingle<Cliente>(sql, new {Id = id});
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }

            return result;
        }
        
        public bool Remover(int id)
        {
            /*string sql = $"delete from cliente where id = {id}";
            MySqlCommand comandoSql = new MySqlCommand(sql, connectionDB);

            try
            {
                connectionDB.Open();
                comandoSql.Prepare();
                bool rowsAffect = comandoSql.ExecuteNonQuery() > 0;
                connectionDB.Close();
                return rowsAffect;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }*/
            int rowAffect;
            try
            {
                string sql = sqlFactory.GetDeleteSql("Id");
                rowAffect = connectionDB.Execute(sql, new {Id = id});
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
                throw;
            }
            return rowAffect > 0;
        }

        public List<Cliente> BuscarTodos()
        {
            List<Cliente> result;
            try
            {
                string sql = sqlFactory.GetSelectSql();
                result = connectionDB.Query<Cliente>(sql).ToList();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }

            return result;
        }
    
        public bool AtualizarCliente(Cliente cliente)
        {
            string sql;
            int rowAffect;
            try
            {
                //PropertyInfo? attribute = cliente.GetType().GetProperty("Id");
                sql = sqlFactory.GetUpdateSql("Id");

                rowAffect = connectionDB.Execute(sql, cliente);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
            return rowAffect > 0;
        }
    
        /*public Cliente buscarPorId(int id)
        {
            string sql = $"select * from cliente where id = {id}";
            MySqlCommand comandoSql = new MySqlCommand(sql, connectionDB);
            Cliente result = new Cliente();

            try
            {
                connectionDB.Open();
                comandoSql.Prepare();
                MySqlDataReader reader = comandoSql.ExecuteReader();


                if (reader.Read())
                {
                    result = new Cliente(
                        reader.GetString("Nome"),
                        reader.GetString("Cpf"),
                        reader.GetString("Cnh"),
                        reader.GetDateTime("DtNascimento"),
                        reader.GetString("Email"),
                        reader.GetString("Rg"),
                        reader.GetString("Telefone"),
                        reader.GetString("Renach"),
                        reader.GetInt32("Id"));
                }

                connectionDB.Close();

                return result;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }

        }*/
        
        /*public List<Cliente> buscarTodos()
        {
            string sql = $"select * from cliente";
            MySqlCommand comandoSql = new MySqlCommand(sql, connectionDB);
            List<Cliente> result = new List<Cliente>();

            try
            {
                connectionDB.Open();
                comandoSql.Prepare();
                var reader = comandoSql.ExecuteReader();
                connectionDB.Close();

                while (reader.Read())
                {
                    result.Add(new Cliente(
                        reader.GetString("Nome"),
                        reader.GetString("Cpf"),
                        reader.GetString("Cnh"),
                        reader.GetDateTime("DtNascimento"),
                        reader.GetString("Email"),
                        reader.GetString("Rg"),
                        reader.GetString("Telefone"),
                        reader.GetString("Renach"),
                        reader.GetInt32("Id")));
                }

                return result;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }*/

    }
}
