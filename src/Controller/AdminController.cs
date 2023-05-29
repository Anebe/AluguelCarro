using AluguelCarro.src.DTO;
using AluguelCarro.src.Entity;
using AluguelCarro.src.Service.Interface;
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
        private IFuncionarioService _funcionarioService;
        private IFilialService _filialService;
        public AdminController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            _funcionarioService = _serviceProvider.GetRequiredService<IFuncionarioService>();
            _filialService = _serviceProvider.GetRequiredService<IFilialService>();
        }


        //FUNCIONÁRIO MÉTODOS --------------------------------------------------------------

        public bool AdicionarFuncionario(FuncionarioDTO funcionario)
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

        public bool AtualizarFuncionario(FuncionarioDTO funcionario)
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

        public FuncionarioDTO BuscarFuncionario(FuncionarioDTO funcionario)
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

        public List<FuncionarioDTO> BuscarFuncionarios()
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

        public bool RemoverFuncionario(FuncionarioDTO funcionario)
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

        public bool AdicionarFuncionario(FilialDTO filial)
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

        public bool AtualizarFilial(FilialDTO filial)
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

        public FilialDTO BuscarFilial(FilialDTO filial)
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

        public List<FilialDTO> BuscarFilials()
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
