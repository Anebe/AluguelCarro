using AluguelCarro.src.DAO.Interface;
using AluguelCarro.src.DTO;
using AluguelCarro.src.Service.Interface;

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
        public bool Adicionar(ClienteDTO item)
        {
            return _clienteDAO.Adicionar(item);
            
        }

        public bool Atualizar(ClienteDTO item)
        {
            return _clienteDAO.Atualizar(item);
            
        }

        public ClienteDTO? BuscarUnico(ClienteDTO item)
        {
            return _clienteDAO.BuscarUnico(item);
        }

        public List<ClienteDTO> BuscarVarios()
        {
            return _clienteDAO.BuscarVarios();
            
        }

        public bool Remover(ClienteDTO item)
        {
            return _clienteDAO.Remover(item);
            
        }

    }


}
