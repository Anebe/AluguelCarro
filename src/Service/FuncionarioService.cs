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
    internal class FuncionarioService : IFuncionarioService, ICrudService<Funcionario>
    {
        private IFuncionarioDAO _funcionarioDAO;
        private IGenericDAO<Funcionario> _gerericDAO;
        private IGenericDAO<Login> _loginDAO;

        public FuncionarioService(IFuncionarioDAO funcionarioDAO, IGenericDAO<Funcionario> gerericDAO, IGenericDAO<Login> loginDAO)
        {
            _funcionarioDAO = funcionarioDAO;
            _gerericDAO = gerericDAO;
            _loginDAO = loginDAO;
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
        
        public Funcionario BuscarUnico(Funcionario funcionario)
        {
            try
            {
                return _gerericDAO.BuscarUnico(funcionario);
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

        public List<Funcionario> BuscarVarios()
        {
            try
            {
                //ClienteValidator.Validar(cliente);
                return _gerericDAO.BuscarVarios();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public bool Remover(Funcionario funcionario)
        {
            try
            {
                //ClienteValidator.Validar(cliente);
                return _gerericDAO.Remover(funcionario);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        /////////////
        public Funcionario Login(Login login)
        {
            var func = _loginDAO.BuscarUnico(login);
            return func != null ? func.Funcionario : null;
        }
    }
}
