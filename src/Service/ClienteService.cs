using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AluguelCarro.src.DAO.Interface;
using AluguelCarro.src.DTO;
using AluguelCarro.src.Entity;
using AluguelCarro.src.Service.Interface;
using MySqlConnector;

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
            var cliente = convertTo(item);
            return _clienteDAO.Adicionar(cliente);
            
        }

        public bool Atualizar(ClienteDTO item)
        {
            var cliente = convertTo(item);
            return _clienteDAO.Atualizar(cliente);
            
        }

        public ClienteDTO? BuscarUnico(ClienteDTO item)
        {
            var cliente = convertTo(item);
            cliente = _clienteDAO.BuscarUnico(cliente);
            var result = convertTo(cliente);
            return result;
            
        }

        public List<ClienteDTO> BuscarVarios()
        {
            var clientes = _clienteDAO.BuscarVarios();
            List<ClienteDTO> result = new List<ClienteDTO>();
            clientes.ForEach(a => result.Add(convertTo(a)));
            return result;
            
        }

        public bool Remover(ClienteDTO item)
        {
            var cliente = convertTo(item);
            return _clienteDAO.Remover(cliente);
            
        }

        //UTIL-------------------
        private static Cliente convertTo(ClienteDTO item)
        {
            Cliente result = new() { Cnh = item.Cnh, Cpf = item.Cpf, DtNascimento = item.DtNascimento, Email = item.Email, Id = item.Id, Nome = item.Nome };
            return result;
        }
        private static ClienteDTO convertTo(Cliente item)
        {
            ClienteDTO result = new() { Cnh = item.Cnh, Cpf = item.Cpf, DtNascimento = item.DtNascimento, Email = item.Email, Id = item.Id, Nome = item.Nome };
            return result;
        }
    }


}
