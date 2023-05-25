using AluguelCarro.src.Entity;
using AluguelCarro.src.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.DAO
{
    internal class CarroDAO: ICarroDAO
    {
        MySqlContext _dbContext;

        public CarroDAO()
        {
            _dbContext = new MySqlContext();
        }

        public List<Carro> BuscaFilterBy(decimal? minPrice, decimal? maxPrice)
        {
            return _dbContext.Carro.Where(a => minPrice.HasValue && a.GrupoCarro.ValorDiaria > minPrice 
                                            || maxPrice.HasValue && a.GrupoCarro.ValorDiaria > maxPrice).ToList();
        }
    }
}
