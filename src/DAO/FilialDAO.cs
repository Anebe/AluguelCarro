using AluguelCarro.src.Entity;
using AluguelCarro.src.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.DAO
{
    internal class FilialDAO : IFilialDAO
    {
        MySqlContext _dbContext;

        public FilialDAO()
        {
            _dbContext = new MySqlContext();
        }
    }
}
