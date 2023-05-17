using AluguelCarro.DTO;
using AluguelCarro.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro
{
    public class Controller
    {
        ClienteService clienteService;

        public Controller()
        {
            clienteService = new ClienteService();
        }
        public bool cadastrar(ClienteDTO cliente)
        {
            return clienteService.cadastrarCliente(cliente);
        }
    }
}
