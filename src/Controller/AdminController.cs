using AluguelCarro.src.DTO;
using AluguelCarro.src.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.Controller
{
    internal class AdminController
    {
        private IServiceProvider _serviceProvider;

        private ICrudService<Funcionario> _crudServiceFuncionario;
        private IFuncionarioService _funcionarioService;

        public AdminController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            _crudServiceFuncionario = _serviceProvider.GetRequiredService<ICrudService<Funcionario>>();
            _funcionarioService = _serviceProvider.GetRequiredService<IFuncionarioService>();
        }



        //FUNCIONÁRIO MÉTODOS --------------------------------------------------------------

        public bool AdicionarFuncionario(Funcionario funcionario)
        {
            try
            {
                return _crudServiceFuncionario.Adicionar(funcionario);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public bool AtualizarFuncionario(Funcionario funcionario)
        {
            try
            {
                return _crudServiceFuncionario.Atualizar(funcionario);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public Funcionario BuscarFuncionario(int id)
        {
            try
            {
                return _crudServiceFuncionario.Buscar(id);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public List<Funcionario> BuscarFuncionario()
        {
            try
            {
                return _crudServiceFuncionario.Buscar();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public bool RemoverFuncionario(int id)
        {
            try
            {
                return _crudServiceFuncionario.Remover(id);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        //FILIAL MÉTODOS --------------------------------------------------------------

    }
}
