using Dapper;
using System.Data;
using AluguelCarro.src.Util;
using AluguelCarro.src.DAO.Interface;
using AluguelCarro.src.DTO;

namespace AluguelCarro.src.DAO
{
    internal class AluguelDAO : IAluguelDAO
    {
        private IDbConnection _dbConnection;
        private IMySqlStringFactory<Aluguel> _sqlFactory;
        private IClienteDAO _clienteDAO;
        private ICarroDAO _carroDAO;

        public AluguelDAO(IDbConnection dbConnection, IMySqlStringFactory<Aluguel> sqlFactory, IClienteDAO clienteDAO, ICarroDAO carroDAO)
        {
            _dbConnection = dbConnection;
            _sqlFactory = sqlFactory;
            _clienteDAO = clienteDAO;
            _carroDAO = carroDAO;
        }

        public bool Adicionar(Aluguel item)
        {
            string sql = _sqlFactory.GetInsertSql("Id");
            int row = _dbConnection.Execute(sql, item);
            return row > 0 && row < 2;
        }

        public bool Atualizar(Aluguel item)
        {
            string sql = _sqlFactory.GetUpdateSql();
            int row = _dbConnection.Execute(sql, item);
            return row > 0 && row < 2;
        }

        public Aluguel? BuscarUnico(Aluguel item)
        {
            try
            {
                string sql = _sqlFactory.GetSelectSql(new string[]{ "Id_carro", "Id_cliente" });
                var aluguel = _dbConnection.QuerySingle<Aluguel>(sql, item);
                aluguel.SetCarro(_carroDAO.BuscarUnico(aluguel.getCarro()));
                aluguel.SetCliente(_clienteDAO.BuscarUnico(aluguel.GetCliente()));
                return aluguel;
            }
            catch (InvalidOperationException)
            {
                throw new Exception("Nenhum carro encontrado.");
            }
        }

        public List<Aluguel> BuscarVarios()
        {
            string sql = _sqlFactory.GetSelectSql();
            var aluguel = _dbConnection.Query<Aluguel>(sql);
            return aluguel.ToList();
        }
        public bool Remover(Aluguel item)
        {
            string sql = _sqlFactory.GetDeleteSql("Id");
            int row = _dbConnection.Execute(sql, item);
            return row > 0 && row < 2;
        }

        public Aluguel getItemBySql(string sql, Aluguel filter)
        {
            var aluguel = _dbConnection.QuerySingle<Aluguel>(sql, filter);
            return aluguel;
        }

        public List<Aluguel> getItensBySql(string sql, Aluguel filter)
        {
            var aluguel = _dbConnection.Query<Aluguel>(sql, filter);
            return aluguel.ToList();
        }

        public List<Aluguel> BuscarVarios(Aluguel filtro)
        {
            try
            {
                string sql = _sqlFactory.GetSelectSql(new string[] { "Id_carro", "Id_cliente" });
                var aluguel = _dbConnection.Query<Aluguel>(sql, filtro).ToList<Aluguel>();
                for (int e = 0; e < aluguel.Count; e++)
                {
                    aluguel[e].SetCarro(_carroDAO.BuscarUnico(aluguel[e].getCarro()));
                    aluguel[e].SetCliente(_clienteDAO.BuscarUnico(aluguel[e].GetCliente()));
                }
                
                return aluguel;
            }
            catch (InvalidOperationException)
            {
                throw new Exception("Nenhum carro encontrado.");
            }
        }
    }
}
