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
    internal class AluguelService : ICrudService<Aluguel>, IAluguelService
    {
        private IGenericDAO<Aluguel> _genericDAO;
        private IAluguelDAO _aluguelDAO;

        public AluguelService(IGenericDAO<Aluguel> genericDAO, IAluguelDAO aluguelDAO)
        {
            _genericDAO = genericDAO;
            _aluguelDAO = aluguelDAO;
        }

        //CRUD ------------------------------------------------
        public bool Adicionar(Aluguel item)
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

        public bool Atualizar(Aluguel item)
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

        public Aluguel? BuscarUnico(Aluguel item)
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

        public List<Aluguel> BuscarVarios()
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

        public bool Remover(Aluguel item)
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
    
        //REGRA DE NEGOCIO ------------------------------------------------
    }
}
