using AluguelCarro.src.DAO.Interface;
using AluguelCarro.src.Service.Interface;
using AluguelCarro.src.DTO;
using AluguelCarro.src.Util;

namespace AluguelCarro.src.Service
{
    internal class AluguelService : IAluguelService
    {
        private IAluguelDAO _aluguelDAO;
        private ISelectCommandString _sql;

        public AluguelService(IAluguelDAO aluguelDAO, ISelectCommandString sql)
        {
            _aluguelDAO = aluguelDAO;
            _sql = sql;
        }


        //CRUD ------------------------------------------------
        public bool Adicionar(Aluguel item)
        {
            try
            {
                List<Aluguel> alugueisCarros = _sql.getItensBySql<Aluguel>("select * from aluguel where id_carro = @Id_carro and dtInicio >= @DtInicio and dtFim <= @DtFim", item);
                if (alugueisCarros.Count > 0)
                {
                    return false;
                }
            }
            catch (Exception)
            {

            }
            var diaria = item.getCarro().Valor_diaria;
            TimeSpan qtdDias = item.DtFim - item.DtInicio;
            item.Total = diaria * qtdDias.Days;

            return _aluguelDAO.Adicionar(item);
        }

        public bool Atualizar(Aluguel item)
        {
            return _aluguelDAO.Atualizar(item);
        }

        public Aluguel? BuscarUnico(Aluguel item)
        {
            return _aluguelDAO.BuscarUnico(item);
        }

        public List<Aluguel> BuscarVarios()
        {
            return _aluguelDAO.BuscarVarios();
        }

        public List<Aluguel> BuscarVarios(Aluguel filtro)
        {
            return _aluguelDAO.BuscarVarios(filtro);
        }

        public bool Remover(Aluguel item)
        {
            return _aluguelDAO.Remover(item);
        }


    }
}
