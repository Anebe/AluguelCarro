﻿using AluguelCarro.src.DTO;
using AluguelCarro.src.Service.Interface;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;

namespace AluguelCarro.src.Controller
{
    public class AtendimentoController
    {
        private IServiceProvider _serviceProvider;

        private IClienteService _clienteService;
        private IAluguelService _aluguelService;
        private ICarroService _carroService;
        private IFuncionarioService _funcionarioService;

        public AtendimentoController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            _clienteService = _serviceProvider.GetRequiredService<IClienteService>();
            _aluguelService = _serviceProvider.GetRequiredService<IAluguelService>();
            _carroService = _serviceProvider.GetRequiredService<ICarroService>();
            _funcionarioService = _serviceProvider.GetRequiredService<IFuncionarioService>();
        }

        
        //CLIENTE MÉTODOS --------------------------------------------------------------
        public bool AdicionarCliente(Cliente cliente)
        {
            return _clienteService.Adicionar(cliente);
        }

        public bool AtualizarCliente(Cliente cliente)
        {
            return _clienteService.Atualizar(cliente);
        }

        public Cliente BuscarCliente(Cliente cliente)
        {
            return _clienteService.BuscarUnico(cliente);
        }

        public List<Cliente> BuscarClientes()
        {
            return _clienteService.BuscarVarios();
        }

        public bool RemoverCliente(Cliente cliente)
        {
            return _clienteService.Remover(cliente);
        }


        //ALUGUEL MÉTODOS --------------------------------------------------------------
        public bool AdicionarAluguel(Aluguel aluguel)
        {
            return _aluguelService.Adicionar(aluguel);
        }

        public bool AtualizarAluguel(Aluguel aluguel)
        {
            return _aluguelService.Atualizar(aluguel);
        }

        public Aluguel? BuscarAluguel(Aluguel aluguel)
        {
            return _aluguelService.BuscarUnico(aluguel);
        }

        public List<Aluguel> BuscarAlugueis()
        {
            return _aluguelService.BuscarVarios();
        }


        //CARRO MÉTODOS --------------------------------------------------------------
        public Carro BuscarCarro(Carro carro)
        {
            return _carroService.BuscarUnico(carro);
        }
        
        public List<Carro> BuscarCarros()
        {
            return _carroService.BuscarVarios();
        }
        
    }
}
