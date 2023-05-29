using AluguelCarro.src.DAO;
using AluguelCarro.src.DAO.Interface;
using AluguelCarro.src.Entity;
using AluguelCarro.src.Service.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.Service
{
    internal class FilialService : ICrudService<Filial>, IFilialService
    {
        private IGenericDAO<Filial> _genericDAO;
        private IFuncionarioDAO _filialDAO;

        public FilialService(IGenericDAO<Filial> genericDAO, IFuncionarioDAO filialDAO)
        {
            _genericDAO = genericDAO;
            _filialDAO = filialDAO;
        }

        public bool Adicionar(Filial item)
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

        public bool Atualizar(Filial item)
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

        public Filial? BuscarUnico(Filial item)
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

        public List<Filial> BuscarVarios()
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

        public bool Remover(Filial item)
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
