using AluguelCarro.src.Entity;
using AluguelCarro.src.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.DAO.Interface
{
    internal interface IClienteDAO : IGenericCRUD<Cliente>
    {
        //public List<Cliente> getClientesInativos(DateTime desdeDe);
    }
}
