using AluguelCarro.src.Entity;
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

        private ICrudService<Filial> _crudServiceFilial;
        private IFilialService _filialService;
        public AdminController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            _crudServiceFuncionario = _serviceProvider.GetRequiredService<ICrudService<Funcionario>>();
            _funcionarioService = _serviceProvider.GetRequiredService<IFuncionarioService>();

            _crudServiceFilial = _serviceProvider.GetRequiredService<ICrudService<Filial>>();
            _filialService = _serviceProvider.GetRequiredService<IFilialService>();
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

        public Funcionario BuscarFuncionario(Funcionario funcionario)
        {
            try
            {
                return _crudServiceFuncionario.BuscarUnico(funcionario);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public List<Funcionario> BuscarFuncionarios()
        {
            try
            {
                return _crudServiceFuncionario.BuscarVarios();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public bool RemoverFuncionario(Funcionario funcionario)
        {
            try
            {
                return _crudServiceFuncionario.Remover(funcionario);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        //FILIAL MÉTODOS --------------------------------------------------------------

        public bool AdicionarFuncionario(Filial filial)
        {
            try
            {
                return _crudServiceFilial.Adicionar(filial);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public bool AtualizarFilial(Filial filial)
        {
            try
            {
                return _crudServiceFilial.Atualizar(filial);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public Filial BuscarFilial(Filial filial)
        {
            try
            {
                return _crudServiceFilial.BuscarUnico(filial);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public List<Filial> BuscarFilials()
        {
            try
            {
                return _crudServiceFilial.BuscarVarios();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public bool RemoverFilial(Filial filial)
        {
            try
            {
                return _crudServiceFilial.Remover(filial);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

    }
}
