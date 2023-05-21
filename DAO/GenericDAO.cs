using AluguelCarro.DTO;
using AluguelCarro.Interface;
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
    public class GenericDAO<T> : IGenericDAO<T> where T : class
    {
        private IDbConnection _connectionDB;
        private IMySqlStringFactory<T> _sqlFactory;
        
        public GenericDAO(IDbConnection connectionDB, IMySqlStringFactory<T> sqlFactory)
        {
            this._connectionDB = connectionDB;
            this._sqlFactory = sqlFactory;
        }
        
        
        
        public bool Adicionar(T item)
        {
            try
            {
                string sql = _sqlFactory.GetInsertSql("Id");
                int rowAffect = _connectionDB.Execute(sql, item);
                return rowAffect > 0;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }
        
        public bool Atualizar(T item)
        {
            try
            {
                var sql = _sqlFactory.GetUpdateSql("Id");
                var rowAffect = _connectionDB.Execute(sql, item);
                return rowAffect > 0;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public T Buscar(int id)
        {
            try
            {
                string sql = _sqlFactory.GetSelectSql("Id");
                return _connectionDB.QuerySingle<T>(sql, new { Id = id });
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public List<T> Buscar()
        {
            try
            {
                string sql = _sqlFactory.GetSelectSql();
                return _connectionDB.Query<T>(sql).ToList();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public bool Remover(int id)
        {
            try
            {
                string sql = _sqlFactory.GetDeleteSql("Id");
                var rowAffect = _connectionDB.Execute(sql, new {Id = id});
                return rowAffect > 0;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }
    }
}
