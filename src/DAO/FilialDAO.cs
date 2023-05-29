﻿using CloneAluguel.DAO.Interface;
using CloneAluguel.Entity;
using CloneAluguel.Util;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneAluguel.DAO
{
    internal class FilialDAO : IGenericDAO<Filial>
    {
        private IDbConnection _dbConnection;
        private IMySqlStringFactory<Filial> _sqlFactory;

        public FilialDAO(IDbConnection dbConnection, IMySqlStringFactory<Filial> sqlFactory)
        {
            _dbConnection = dbConnection;
            _sqlFactory = sqlFactory;
        }

        public bool Adicionar(Filial item)
        {
            string sql = _sqlFactory.GetInsertSql();
            int row = _dbConnection.Execute(sql, item);
            return row > 0 && row < 2;
        }

        public bool Atualizar(Filial item)
        {
            string sql = _sqlFactory.GetUpdateSql();
            int row = _dbConnection.Execute(sql, item);
            return row > 0 && row < 2;
        }

        public Filial? BuscarUnico(Filial item)
        {
            string sql = _sqlFactory.GetSelectSql();
            var filial = _dbConnection.QuerySingle<Filial>(sql, item);
            return filial;
        }

        public List<Filial> BuscarVarios()
        {
            string sql = _sqlFactory.GetSelectSql();
            var filial = _dbConnection.Query<Filial>(sql);
            return filial.ToList();
        }

        public bool Remover(Filial item)
        {
            string sql = _sqlFactory.GetDeleteSql("Id");
            int row = _dbConnection.Execute(sql, item);
            return row > 0 && row < 2;
        }
    }
}