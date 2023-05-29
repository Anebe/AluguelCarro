using AluguelCarro.src.DAO.Interface;
using AluguelCarro.src.DTO;
using AluguelCarro.src.Entity;
using AluguelCarro.src.Service.Interface;
using AluguelCarro.src.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AluguelCarro.src.Service
{
    internal class CarroService : ICarroService
    {
        private ICarroDAO _carroDAO;

        public CarroService(ICarroDAO carroDAO)
        {
            _carroDAO = carroDAO;
        }

        public bool Adicionar(CarroDTO item)
        {
            throw new NotImplementedException();
        }

        public bool Atualizar(CarroDTO item)
        {
            throw new NotImplementedException();
        }

        public CarroDTO? BuscarUnico(CarroDTO item)
        {
            throw new NotImplementedException();
        }

        public List<CarroDTO> BuscarVarios()
        {
            throw new NotImplementedException();
        }

        public bool Remover(CarroDTO item)
        {
            throw new NotImplementedException();
        }
    }
}
