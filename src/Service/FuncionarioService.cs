using AluguelCarro.src.DAO;
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
    internal class FuncionarioService : IFuncionarioService
    {
        private IFuncionarioDAO _funcionarioDAO;
        private IFilialDAO _filialDAO;
        public FuncionarioService(IFuncionarioDAO funcionarioDAO, IFilialDAO filialDAO)
        {
            _funcionarioDAO = funcionarioDAO;
            _filialDAO = filialDAO;
        }

        //CRUD--------------------------
        public bool Adicionar(FuncionarioDTO item)
        {
            var cliente = convertTo(item);
            return _funcionarioDAO.Adicionar(cliente);
        }

        public bool Atualizar(FuncionarioDTO item)
        {
            throw new NotImplementedException();
        }

        public FuncionarioDTO? BuscarUnico(FuncionarioDTO item)
        {
            throw new NotImplementedException();
        }

        public List<FuncionarioDTO> BuscarVarios()
        {
            throw new NotImplementedException();
        }

        public bool Remover(FuncionarioDTO item)
        {
            throw new NotImplementedException();
        }
        public Funcionario Login(Login login)
        {
            throw new NotImplementedException();
        }

        //UTIL
        private Funcionario convertTo(FuncionarioDTO item)
        {
            Funcionario result = new() { Cargo = item.Cargo, Cpf = item.Cpf, DataContratacao = item.DataContratacao, Email = item.Email, Filial_id = item.FilialAssociado.Id, Id = item.Id, Nome = item.Nome, Rg = item.Rg, Salario = item.Salario, Telefone = item.Telefone };
            return result;
        }
        private FuncionarioDTO convertTo(Funcionario item)
        {
            FuncionarioDTO ressult = new()
            {
                Cargo = item.Cargo,
                Cpf = item.Cpf,
                Telefone = item.Telefone,
                Salario = item.Salario,
                Rg = item.Rg,
                Nome = item.Nome,
                Id = item.Id,
                DataContratacao = item.DataContratacao,
                Email = item.Email,
                FilialAssociado = _filialDAO.BuscarUnico(new Filial() { Id = item.Filial_id})
            }
        }
    }
}
