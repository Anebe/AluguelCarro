using AluguelCarro.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.Interface
{
    internal interface IClienteService
    {
        public bool Adicionar(Cliente item);
        public bool Atualizar(Cliente item);
        public bool Remover(int id);
        public List<Cliente> Buscar();
        public Cliente Buscar(int id);
    }
}
