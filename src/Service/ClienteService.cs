using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AluguelCarro.src.DAO.Interface;
using AluguelCarro.src.Entity;
using AluguelCarro.src.Service.Interface;
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


        //CRUD-------------------------------
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

        public Cliente? BuscarUnico(Cliente cliente)
        {
            try
            {
                return _gerericDAO.BuscarUnico(cliente);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public List<Cliente> BuscarVarios()
        {
            try
            {
                //ClienteValidator.Validar(cliente);
                return _gerericDAO.BuscarVarios();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public bool Remover(Cliente cliente)
        {
            try
            {
                //ClienteValidator.Validar(cliente);
                return _gerericDAO.Remover(cliente);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }



        //REGRA DE NEGOCIO-----------------------------------------------------
        public List<Cliente?>? getClientesInativos(DateTime desdeDe)
        {
            if (desdeDe.Date < DateTime.Now.Date && desdeDe.Subtract(DateTime.Now).Hours > 24)
            {
                return _clienteDAO.getClientesInativos(desdeDe);
            }
            return null;
        }
    }


}
