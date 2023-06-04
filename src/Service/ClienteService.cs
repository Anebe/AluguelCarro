using AluguelCarro.src.DAO.Interface;
using AluguelCarro.src.DTO;
using AluguelCarro.src.Service.Interface;
using AluguelCarro.src.Validator;

namespace AluguelCarro.src.Service
{
    internal class ClienteService : IClienteService
    {
        private IClienteDAO _clienteDAO;

        public ClienteService(IClienteDAO clienteDAO)
        {
            _clienteDAO = clienteDAO;
        }


        //CRUD-------------------------------
        public bool Adicionar(Cliente item)
        {
            ClienteValidator.Validar(item);
            return _clienteDAO.Adicionar(item);
        }

        public bool Atualizar(Cliente item)
        {
            ClienteValidator.Validar(item);
            return _clienteDAO.Atualizar(item);
        }

        public Cliente? BuscarUnico(Cliente item)
        {
            return _clienteDAO.BuscarUnico(item);
        }

        public List<Cliente> BuscarVarios()
        {
            return _clienteDAO.BuscarVarios();
        }

        public bool Remover(Cliente item)
        {
            return _clienteDAO.Remover(item);
        }
    }
}
