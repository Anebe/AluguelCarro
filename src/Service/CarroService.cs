using AluguelCarro.src.DAO.Interface;
using AluguelCarro.src.DTO;
using AluguelCarro.src.Service.Interface;


namespace AluguelCarro.src.Service
{
    internal class CarroService : ICarroService
    {
        private ICarroDAO _carroDAO;

        public CarroService(ICarroDAO carroDAO)
        {
            _carroDAO = carroDAO;
        }

        public bool Adicionar(Carro item)
        {
            return _carroDAO.Adicionar(item);
        }

        public bool Atualizar(Carro item)
        {
            return _carroDAO.Atualizar(item);
        }

        public Carro? BuscarUnico(Carro item)
        {
            return _carroDAO.BuscarUnico(item);
        }

        public List<Carro> BuscarVarios()
        {
            return _carroDAO.BuscarVarios();
        }

        public bool Remover(Carro item)
        {
            return _carroDAO.Remover(item);
        }
    }
}
