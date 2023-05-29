using AluguelCarro.src.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.Service.Interface
{
    internal interface IClienteService
    {
        public List<Cliente?>? getClientesInativos(DateTime desdeDe);
    }
}
