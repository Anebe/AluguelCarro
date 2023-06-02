using AluguelCarro.src.DTO;
using AluguelCarro.src.Service.Interface;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;


namespace AluguelCarro.src.Controller
{
    internal class AdminController
    {
        private IServiceProvider _serviceProvider;
        private IFuncionarioService _funcionarioService;
        private IFilialService _filialService;
        public AdminController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            _funcionarioService = _serviceProvider.GetRequiredService<IFuncionarioService>();
            _filialService = _serviceProvider.GetRequiredService<IFilialService>();
        }


        //FUNCIONÁRIO MÉTODOS --------------------------------------------------------------

        public bool AdicionarFuncionario(Funcionario funcionario)
        {
            try
            {
                return _funcionarioService.Adicionar(funcionario);
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
                return _funcionarioService.Atualizar(funcionario);
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
                return _funcionarioService.BuscarUnico(funcionario);
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
                return _funcionarioService.BuscarVarios();
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
                return _funcionarioService.Remover(funcionario);
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
                return _filialService.Adicionar(filial);
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
                return _filialService.Atualizar(filial);
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
                return _filialService.BuscarUnico(filial);
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
                return _filialService.BuscarVarios();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

    }
}
