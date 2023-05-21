using AluguelCarro.DTO;
using AluguelCarro.Interface;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace AluguelCarro
{
    public class Controller
    {
        private IClienteService _clienteService;
        private IServiceProvider _serviceProvider;
        public Controller()
        {
            _serviceProvider = Startup.GetServiceProvider();
            _clienteService = _serviceProvider.GetRequiredService<IClienteService>();
        }

        public bool AdicionarCliente(string nome, string cpf, string cnh, DateTime dtNascimento, string email, string rg, string telefone, string renach)
        {
            try
            {
                return _clienteService.Adicionar(new Cliente(nome, cpf, cnh, dtNascimento, email, rg, telefone, renach));
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
                return _clienteService.Buscar(id);
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
                return _clienteService.Buscar();
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
                return _clienteService.Remover(id);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

    }
}
