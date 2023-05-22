using AluguelCarro.DAO;
using AluguelCarro.src.DTO;
using AluguelCarro.src.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.Service
{
    internal class FuncionarioService : IFuncionarioService, ICrudService<Funcionario>
    {
        private IFuncionarioDAO _funcionarioDAO;
        private IGenericDAO<Funcionario> _gerericDAO;

        public FuncionarioService(IFuncionarioDAO funcionarioDAO, IGenericDAO<Funcionario> gerericDAO)
        {
            _funcionarioDAO = funcionarioDAO;
            _gerericDAO = gerericDAO;
        }

        public bool Adicionar(Funcionario funcionario)
        {
            try
            {
                //FuncionarioValidator.Validar(funcionario);
                return _gerericDAO.Adicionar(funcionario);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public List<Funcionario> Buscar()
        {
            try
            {
                //ClienteValidator.Validar(cliente);
                return _gerericDAO.Buscar();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public Funcionario Buscar(int id)
        {
            try
            {
                return _gerericDAO.Buscar(id);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public bool Atualizar(Funcionario funcionario)
        {
            try
            {
                //ClienteValidator.Validar(cliente);
                return _gerericDAO.Atualizar(funcionario);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public bool Remover(int id)
        {
            try
            {
                //ClienteValidator.Validar(cliente);
                var funcionario = Buscar(id);
                return _gerericDAO.Remover(funcionario);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

    }
}
