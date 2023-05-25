using AluguelCarro.src.Entity;
using AluguelCarro.src.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.DAO
{
    internal class AluguelDAO : IAluguelDAO
    {
        MySqlContext _dbContext;

        public AluguelDAO()
        {
            _dbContext = new MySqlContext();
        }

        public List<Aluguel> BuscarFilterBy(Estado estado)
        {
           return _dbContext.Aluguel.Where(a => a.Estado == estado).ToList();
        }
    }
}
