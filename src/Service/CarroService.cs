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

        public bool Adicionar(CarroDTO item)
        {
            throw new NotImplementedException();
        }

        public bool Atualizar(CarroDTO item)
        {
            throw new NotImplementedException();
        }

        public CarroDTO? BuscarUnico(CarroDTO item)
        {
            throw new NotImplementedException();
        }

        public List<CarroDTO> BuscarVarios()
        {
            throw new NotImplementedException();
        }

        public bool Remover(CarroDTO item)
        {
            throw new NotImplementedException();
        }
    }
}
