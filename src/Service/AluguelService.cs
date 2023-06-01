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
        public bool Adicionar(AluguelDTO item)
        {
            throw new NotImplementedException();
        }

        public bool Atualizar(AluguelDTO item)
        {
            throw new NotImplementedException();
        }

        public AluguelDTO? BuscarUnico(AluguelDTO item)
        {
            throw new NotImplementedException();
        }

        public List<AluguelDTO> BuscarVarios()
        {
            throw new NotImplementedException();
        }

        public bool Remover(AluguelDTO item)
        {
            throw new NotImplementedException();
        }


        //REGRA DE NEGOCIO ------------------------------------------------
    }
}
