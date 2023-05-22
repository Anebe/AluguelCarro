using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AluguelCarro.src.DTO;
using AluguelCarro.src.Interface;
using MySqlConnector;

namespace AluguelCarro.src.Service
{
    internal class ClienteService : IClienteService, ICrudService<Cliente>
    {
        private IClienteDAO _clienteDAO;
        private IGenericDAO<Cliente> _gerericDAO;

        public ClienteService(IClienteDAO clienteDAO, IGenericDAO<Cliente> gerericDAO)
        {
            _clienteDAO = clienteDAO;
            _gerericDAO = gerericDAO;
        }

        public bool Adicionar(Cliente cliente)
        {
            try
            {
                //ClienteValidator.Validar(cliente);
                return _gerericDAO.Adicionar(cliente);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public List<Cliente> Buscar()
        {
            try
            {
                //ClienteValidator.Validar(cliente);
                return _gerericDAO.Buscar();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public Cliente Buscar(int id)
        {
            try
            {
                return _gerericDAO.Buscar(id);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public bool Atualizar(Cliente cliente)
        {
            try
            {
                //ClienteValidator.Validar(cliente);
                return _gerericDAO.Atualizar(cliente);
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
                //ClienteValidator.Validar(cliente);
                var cliente = Buscar(id);
                return _gerericDAO.Remover(cliente);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }
    }


}
