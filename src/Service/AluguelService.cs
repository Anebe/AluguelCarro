using AluguelCarro.src.DAO.Interface;
using AluguelCarro.src.Service.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AluguelCarro.src.Util;
using AluguelCarro.src.DTO;

namespace AluguelCarro.src.Service
{
    internal class AluguelService : IAluguelService
    {
        private IAluguelDAO _aluguelDAO;

        public AluguelService(IAluguelDAO aluguelDAO)
        {
            _aluguelDAO = aluguelDAO;
        }


        //CRUD ------------------------------------------------
        public bool Adicionar(Aluguel item)
        {
            return _aluguelDAO.Adicionar(item);
        }

        public bool Atualizar(Aluguel item)
        {
            return _aluguelDAO.Atualizar(item);
        }

        public Aluguel? BuscarUnico(Aluguel item)
        {
            return _aluguelDAO.BuscarUnico(item);
        }

        public List<Aluguel> BuscarVarios()
        {
            return _aluguelDAO.BuscarVarios();
        }

        public bool Remover(Aluguel item)
        {
            return _aluguelDAO.Remover(item);
        }


        //REGRA DE NEGOCIO ------------------------------------------------
    }
}
