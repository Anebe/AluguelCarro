using AluguelCarro.src.DTO;
using AluguelCarro.src.Entity;
using AluguelCarro.src.Service.Interface;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
using System.Security.Cryptography.Pkcs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace AluguelCarro.src.Controller
{
    public class AtendimentoController
    {
        private IServiceProvider _serviceProvider;

        private ICrudService<Cliente> _crudServiceCliente;
        private IClienteService _clienteService;

        private ICrudService<Aluguel> _crudServiceAluguel;
        private IAluguelService _aluguelService;

        private ICrudService<Carro> _crudServiceCarro;
        private ICarroService _carroService;

        private IFuncionarioService _funcionarioService;
        private Funcionario _funcLogado;

        public AtendimentoController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            _crudServiceCliente = _serviceProvider.GetRequiredService<ICrudService<Cliente>>();
            _clienteService = _serviceProvider.GetRequiredService<IClienteService>();
            
            _crudServiceAluguel = _serviceProvider.GetRequiredService<ICrudService<Aluguel>>();
            _aluguelService = _serviceProvider.GetRequiredService<IAluguelService>();

            _crudServiceCarro = _serviceProvider.GetRequiredService<ICrudService<Carro>>();
            _carroService = _serviceProvider.GetRequiredService<ICarroService>();

            _funcionarioService = _serviceProvider.GetRequiredService<IFuncionarioService>();
        }


        //
        public bool login(string usuario, string senha)
        {
            Login login = new() { Usuario = usuario, Senha = senha };
            _funcLogado = _funcionarioService.Login(login);
            return _funcLogado != null ? true : false;
        }
        
        //CLIENTE MÉTODOS --------------------------------------------------------------
        public bool AdicionarCliente(Cliente cliente)
        {
            try
            {
                return _crudServiceCliente.Adicionar(cliente);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public bool AtualizarCliente(Cliente cliente)
        {
            try
            {
                return _crudServiceCliente.Atualizar(cliente);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public Cliente BuscarCliente(Cliente cliente)
        {
            try
            {
                return _crudServiceCliente.BuscarUnico(cliente);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public List<Cliente> BuscarClientes()
        {
            try
            {
                return _crudServiceCliente.BuscarVarios();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public bool RemoverCliente(Cliente cliente)
        {
            try
            {
                return _crudServiceCliente.Remover(cliente);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }


        //ALUGUEL MÉTODOS --------------------------------------------------------------
        public bool AdicionarAluguel(Aluguel aluguel)
        {
            try
            {
                return _crudServiceAluguel.Adicionar(aluguel);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public bool AtualizarAluguel(Aluguel aluguel)
        {
            try
            {
                return _crudServiceAluguel.Atualizar(aluguel);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public Aluguel? BuscarAluguel(Aluguel aluguel)
        {
            try
            {
                return _crudServiceAluguel.BuscarUnico(aluguel);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public List<Aluguel> BuscarAlugueis()
        {
            try
            {
                return _crudServiceAluguel.BuscarVarios();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }


        //CARRO MÉTODOS --------------------------------------------------------------
        public Carro BuscarCarro(Carro carro)
        {
            try
            {
                return _crudServiceCarro.BuscarUnico(carro);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }
        
        public List<Carro> BuscarCarros()
        {
            try
            {
                return _crudServiceCarro.BuscarVarios();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }
        
        //UTIL --------------------------------------------------------------
        private Aluguel ConvertTo(AluguelDTO aluguel)
        {
            throw new NotImplementedException();
        }
    }
}
