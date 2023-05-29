using AluguelCarro.src.DTO;
using AluguelCarro.src.Entity;
using AluguelCarro.src.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.Service.Interface
{
    internal interface IClienteService : IGenericCRUD<ClienteDTO>
    {
        //public List<Cliente?>? getClientesInativos(DateTime desdeDe);
    }
}
