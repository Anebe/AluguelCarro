using AluguelCarro.src.DTO;
using AluguelCarro.src.DTO.VO;
using AluguelCarro.src.Service.Interface;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace AluguelCarro.src.Controller
{
    public class AtendimentoController
    {
        private IServiceProvider _serviceProvider;

        private IClienteService _clienteService;
        private IAluguelService _aluguelService;
        private ICarroService _carroService;

        public AtendimentoController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            _clienteService = _serviceProvider.GetRequiredService<IClienteService>();
            _aluguelService = _serviceProvider.GetRequiredService<IAluguelService>();
            _carroService = _serviceProvider.GetRequiredService<ICarroService>();
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

        public Cliente? BuscarCliente(Cliente cliente)
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
        private bool verificarAluguel(AluguelVO aluguel, Cliente cliente, Carro carro)
        {
            if (aluguel.DataFim < aluguel.DataInicio ||
                cliente == null ||
                carro == null)
            {
                return false;
            }

            return true;
        }

        public bool AdicionarAluguel(AluguelVO aluguel)
        {
            var item = new Aluguel() { DtFim = aluguel.DataFim, DtInicio = aluguel.DataInicio };

            var carro = _carroService.BuscarUnico(new Carro() { Id = aluguel.Id_carro });
            var cliente = _clienteService.BuscarUnico(new Cliente() { Id = aluguel.Id_cliente });

            if(verificarAluguel(aluguel, cliente, carro))
            {
                item.SetCarro(carro);
                item.SetCliente(cliente);

                return _aluguelService.Adicionar(item);
            }
            return false;
        }

        public bool AtualizarAluguel(AluguelVO aluguel)
        {
            var item = new Aluguel() { DtFim = aluguel.DataFim, DtInicio = aluguel.DataInicio };

            var carro = _carroService.BuscarUnico(new Carro() { Id = aluguel.Id_carro });
            var cliente = _clienteService.BuscarUnico(new Cliente() { Id = aluguel.Id_cliente });

            if (verificarAluguel(aluguel, cliente, carro))
            {
                return _aluguelService.Atualizar(item);
            }
            return false;
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
        public bool AdicionarCarro(Carro carro)
        {
            try
            {
                return _carroService.Adicionar(carro);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public bool AtualizarCarro(Carro carro)
        {
            try
            {
                return _carroService.Atualizar(carro);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public Carro BuscarCarro(Carro carro)
        {
            try
            {
                return _carroService.BuscarUnico(carro);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public List<Carro> BuscarCarroS()
        {
            try
            {
                return _carroService.BuscarVarios();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public bool RemoverCarro(Carro carro)
        {
            try
            {
                return _carroService.Remover(carro);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

    }
}
