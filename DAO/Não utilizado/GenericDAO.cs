using AluguelCarro.DTO;
using Dapper;
using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AluguelCarro.DAO
{
    public class GenericDAO<T> : IGenericDAO<T>
    {
        private MySqlConnection connectionDB;

        public GenericDAO(MySqlConnection connectionDB)
        {
            this.connectionDB = connectionDB;
        }
        
        public bool Adicionar(T item)
        {
            
            string tabela = typeof(T).Name;
            List<string> colunas = new();
            List<MySqlParameter> valores = new();
            bool rowAffect = false;

            foreach (var elemento in typeof(T).GetProperties())
            {
                if (elemento.GetValue(item) != null && elemento.Name.ToUpper() != "ID")
                {
                    colunas.Add(elemento.Name);
                    valores.Add(new MySqlParameter("@" + elemento.Name, elemento.GetValue(item)));
                }
            }

            string sql =    "insert into " + tabela + "(" + string.Join(", ", colunas) + ")" + 
                            "values(@" + string.Join(", @", colunas) + ")";

            MySqlCommand comandoSql = new(sql, connectionDB);

            valores.ForEach(item => comandoSql.Parameters.Add(item));

            try
            {
                connectionDB.Open();
                comandoSql.Prepare();
                rowAffect = comandoSql.ExecuteNonQuery() > 0;
                connectionDB.Close();
            }catch(Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return rowAffect;
            

            
        }
        
        public bool Atualizar(T item)
        {
            throw new NotImplementedException();
        }

        public T BuscarPorId(int id)
        {
            string tabela = typeof(T).Name;
            string sql = $"select * from {tabela} where id = {id}";
            T? result;
            //MySqlCommand comandoSql = new MySqlCommand(sql, connectionDB);
            //MySqlDataReader reader;

            try
            {
                connectionDB.Open();
                //comandoSql.Prepare();
                //reader = comandoSql.ExecuteReader();


                /*while (reader.Read())
                {
                    
                    foreach (var elemento in typeof(T).GetProperties())
                    {
                    }
                }*/
                result = connectionDB.QueryFirst<T>(sql);
                connectionDB.Close();
                if(result == null)
                {
                    //result = T.VAZIO;
                }
                
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            throw new NotImplementedException();
        }

        public List<T> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public bool Remover(T item)
        {
            throw new NotImplementedException();
        }

    }
}
