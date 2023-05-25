using AluguelCarro.src.DAO;
using AluguelCarro.src.Entity;
using AluguelCarro.src.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.Service
{
    internal class CarroService : ICrudService<Carro>, ICarroService
    {
        private ICarroDAO _carroDAO;
        private IGenericDAO<Carro> _genericDAO;

        public CarroService(ICarroDAO carroDAO, IGenericDAO<Carro> genericDAO)
        {
            _carroDAO = carroDAO;
            _genericDAO = genericDAO;
        }

        public bool Adicionar(Carro item)
        {
            try
            {
                return _genericDAO.Adicionar(item);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public bool Atualizar(Carro item)
        {
            try
            {
                return _genericDAO.Atualizar(item);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public Carro? BuscarUnico(Carro item)
        {
            try
            {
                return _genericDAO.BuscarUnico(item);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public List<Carro> BuscarVarios()
        {
            try
            {
                return _genericDAO.BuscarVarios();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public bool Remover(Carro item)
        {
            try
            {
                return _genericDAO.Remover(item);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }
    }
}
