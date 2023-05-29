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
    public class CarroDAO : ICarroDAO
    {
        private IDbConnection _dbConnection;
        private IMySqlStringFactory<CarroDTO> _sqlFactory;

        public CarroDAO(IDbConnection dbConnection, IMySqlStringFactory<CarroDTO> sqlFactory)
        {
            _dbConnection = dbConnection;
            _sqlFactory = sqlFactory;
        }

        public bool Adicionar(CarroDTO item)
        {
            string sql = _sqlFactory.GetInsertSql();
            int row = _dbConnection.Execute(sql, item);
            return row > 0 && row < 2;
        }

        public bool Atualizar(CarroDTO item)
        {
            string sql = _sqlFactory.GetUpdateSql();
            int row = _dbConnection.Execute(sql, item);
            return row > 0 && row < 2;
        }

        public CarroDTO? BuscarUnico(CarroDTO item)
        {
            string sql = _sqlFactory.GetSelectSql();
            var carro = _dbConnection.QuerySingle<CarroDTO>(sql, item);
            return carro;
        }

        public List<CarroDTO> BuscarVarios()
        {
            string sql = _sqlFactory.GetSelectSql();
            var carro = _dbConnection.Query<CarroDTO>(sql);
            return carro.ToList();
        }

        public bool Remover(CarroDTO item)
        {
            string sql = _sqlFactory.GetDeleteSql("Id");
            int row = _dbConnection.Execute(sql, item);
            return row > 0 && row < 2;
        }
    }
}
