using AluguelCarro.src.DTO;
using AluguelCarro.src.Interface;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
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

        public AtendimentoController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            _crudServiceCliente = _serviceProvider.GetRequiredService<ICrudService<Cliente>>();
            _clienteService = _serviceProvider.GetRequiredService<IClienteService>();
            
            _crudServiceAluguel = _serviceProvider.GetRequiredService<ICrudService<Aluguel>>();
            _aluguelService = _serviceProvider.GetRequiredService<IAluguelService>();
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

        public Cliente BuscarCliente(int id)
        {
            try
            {
                return _crudServiceCliente.Buscar(id);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public List<Cliente> BuscarCliente()
        {
            try
            {
                return _crudServiceCliente.Buscar();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public bool RemoverCliente(int id)
        {
            try
            {
                return _crudServiceCliente.Remover(id);
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

        public Aluguel BuscarAluguel(int id)
        {
            try
            {
                return _crudServiceAluguel.Buscar(id);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public List<Aluguel> BuscarAluguel()
        {
            try
            {
                return _crudServiceAluguel.Buscar();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public bool RemoverAluguel(int id)
        {
            try
            {
                return _crudServiceAluguel.Remover(id);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

    }
}
