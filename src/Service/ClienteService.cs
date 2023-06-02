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
            try
            {
                ClienteValidator.Validar(item);
                return _clienteDAO.Adicionar(item);
            }catch(ArgumentException e)
            {
                throw e;
            }
            
        }

        public bool Atualizar(Cliente item)
        {
            try
            {
                ClienteValidator.Validar(item);
                return _clienteDAO.Atualizar(item);
            }
            catch (ArgumentException e)
            {
                throw e;
            }
        }

        public Cliente? BuscarUnico(Cliente item)
        {
            try
            {
                ClienteValidator.Validar(item);
                return _clienteDAO.BuscarUnico(item);
            }
            catch (ArgumentException e)
            {
                throw e;
            }
        }

        public List<Cliente> BuscarVarios()
        {
            try
            {
                return _clienteDAO.BuscarVarios();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool Remover(Cliente item)
        {
            try
            {
                ClienteValidator.Validar(item);
                return _clienteDAO.Remover(item);
            }
            catch (ArgumentException e)
            {
                throw e;
            }
        }
    }
}
