using AluguelCarro.DTO;
using System.Data;


namespace AluguelCarro.DAO
{
    public class ClienteDAO
    {
        /*
        private string connectStr = "server=localhost;uid=root;pwd=;database=aluguel_carro";
        MySqlConnection connectionMySql;
        public ClienteDAO()
        {
            connectStr = "server=localhost;uid=root;pwd=;database=aluguel_carro";
            connectionMySql = new MySqlConnection(connectStr);
        }
        internal bool cadastrarCliente(ClienteDTO cliente)
        {
            string comandoStr = "insert into cliente (nome,cpf,CNH,dtNascimento,email,rg,telefone,RENEACH)" +
                                "values (@nome, @cpf, @CNH, @dtNascimento, @email, @rg, @telefone, @RENEACH)";

            MySqlCommand comandoSQL = new MySqlCommand(comandoStr, connectionMySql);

            comandoSQL.Parameters.AddWithValue("@nome", cliente.nome);
            comandoSQL.Parameters.AddWithValue("@cpf", cliente.cpf);
            comandoSQL.Parameters.AddWithValue("@CNH", cliente.cnh);
            comandoSQL.Parameters.AddWithValue("@dtNascimento", cliente.dtNascimento);
            comandoSQL.Parameters.AddWithValue("@email", cliente.email);
            comandoSQL.Parameters.AddWithValue("@rg", cliente.rg);
            comandoSQL.Parameters.AddWithValue("@telefone", cliente.telefone);
            comandoSQL.Parameters.AddWithValue("@RENEACH", cliente.renach);

            connectionMySql.Open();
            comandoSQL.Prepare();
            var result = comandoSQL.ExecuteNonQuery() == 0 ? false : true;
            connectionMySql.Close();

            return result;
        }
        */


        private IGenericDAO<ClienteDTO> simpleCrud;
        private IDbConnection connectionDB;

        public ClienteDAO(IGenericDAO<ClienteDTO> teste, IDbConnection etste)
        {
            this.simpleCrud = teste;
            this.connectionDB = etste;
        }

        public bool adicionarCliente(ClienteDTO cliente)
        {
            return simpleCrud.adicionar(cliente);
        }
    }
}
