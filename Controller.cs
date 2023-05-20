using AluguelCarro.DAO;
using AluguelCarro.DTO;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluguelCarro
{
    public class Controller
    {
        private ClienteDAO clienteDao;
        private MySqlConnection connectDb;

        public Controller()
        {
            connectDb = new MySqlConnection("server=localhost;uid=root;pwd=;database=aluguel_carro");
            clienteDao = new ClienteDAO(connectDb);
        }
        public bool AdicionarCliente(string nome, string cpf, string cnh, DateTime dtNascimento, string email, string rg, string telefone, string renach)
        {
            try
            {
                return clienteDao.Adicionar( new Cliente(nome, cpf, cnh, dtNascimento, email, rg, telefone, renach));
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        /*public bool RemoverCliente()
        {

        }*/

        public List<Cliente> BuscarClientes()
        {
            return clienteDao.BuscarTodos();
        }
    }
}
