using AluguelCarro.src.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.DAO.Interface
{
    internal interface ICarroDAO
    {
        public List<Carro> BuscaFilterBy(decimal? minPrice, decimal? maxPrice);
    }
}
