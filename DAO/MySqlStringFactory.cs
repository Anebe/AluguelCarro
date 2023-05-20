using AluguelCarro.DTO;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.DAO
{
    internal class MySqlStringFactory<T>
    {
        private string table;
        private string[] collunms;
        public MySqlStringFactory()
        {
            table = typeof(T).Name;
            collunms = typeof(T).GetProperties().Select(p => p.Name).ToArray<String>();
        }
        
        public string GetInsertSql(string exceptFor)
        {
            var colunmsChoosen = string.Join(", ", collunms
                                                    .Where(p => p != exceptFor));
            var valuesChoosen = string.Join(", ",  collunms
                                                    .Where(p => p != exceptFor)
                                                    .Select(p => $"@{p}"));

            string sql = $"insert into {table} ({colunmsChoosen}) values ({valuesChoosen})";

            return sql;
        }

        public string GetSelectSql(string? attributesCondition = null)
        {
            string sql = $"select * from {table}";

            if(attributesCondition != null)
            {
                var condition = $"{attributesCondition} = @{attributesCondition}";
                sql += $"where {condition}";
            }

            return sql;
        }

        public string GetUpdateSql(string? attributesCondition = null)
        {
            var attVal = collunms.Select(p => $"{p} = @{p}");
            var attributesAndValues = string.Join(", ", attVal);
            string sql = $"update {table} set {attributesAndValues}";
            if (attributesCondition != null)
            {
                var condition = $"{attributesCondition} = @{attributesCondition}";
                sql += $" where {condition}";
            }

            return sql;
        }

        public string GetDeleteSql(string attributesCondition)
        {
            var condition = $"{attributesCondition} = @{attributesCondition}";
            string sql = $"delete from {table} where {condition}";

            return sql;
        }


        /*public string GetSelectSql(PropertyInfo? attributesCondition = null)
        {
            string sql = "";
            List<string> valores = new List<string>();
            string condiction = "";
            
            valores = typeof(T).GetProperties()
                                .Select(p => p.Name)
                                .ToList<string>();

            if (attributesCondition != null)
            {
                condiction = attributesCondition.Name;
                sql += $"select {string.Join(", ", valores)} from {typeof(T).Name} where {condiction} = @{condiction}";
            }
            else
            {
                sql += $"select {string.Join(", ", valores)} from {typeof(T).Name} ";
            }
            

            return sql;
        }*/

        /*public string GetUpdateSql(PropertyInfo? attributesCondition = null)
        {
            string sql = "";
            List<string> valores = new List<string>();

            
            valores = typeof(T).GetProperties()
                                .Select(p => p.Name)
                                .ToList<string>();

            var table = typeof(T).Name;
            var attributesValues = valores.Select(v => $"{v} = @{v}");
            var attributesValuesJoin = string.Join(", ", attributesValues);
            

            sql += $"update {table} set {attributesValuesJoin}";

            if(attributesCondition != null)
            {
                var condition = $"{attributesCondition.Name} = @{attributesCondition.Name}";
                sql += $" where {condition}";
            }

            return sql;
        }*/
       
        /*private string GetInsertSql(PropertyInfo? exceptFor = null)
        {

            string sql = "";
            List<string> valores = new List<string>();

            if (exceptFor != null)
            {
                valores = typeof(T).GetProperties()
                                    .Where(p => exceptFor != p)
                                    .Select(p => p.Name)
                                    .ToList<string>();
            }
            else
            {
                valores = typeof(T).GetProperties()
                                    .Select(p => p.Name)
                                    .ToList<string>();
            }

            sql += $"insert into {typeof(T).Name} ({string.Join(", ", valores)})" +
                    $"values (@{string.Join(", @", valores)})";

            Debug.Write($"Class: {this.GetType().BaseType}, Method: GetInsertSql, return: {sql}");

            return sql;
        }*/
    }
}
