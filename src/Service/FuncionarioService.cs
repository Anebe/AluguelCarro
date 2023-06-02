using AluguelCarro.src.DAO.Interface;
using AluguelCarro.src.DTO;
using AluguelCarro.src.Service.Interface;

namespace AluguelCarro.src.Service
{
    internal class FuncionarioService : IFuncionarioService
    {
        private IFuncionarioDAO _funcionarioDAO;

        public FuncionarioService(IFuncionarioDAO funcionarioDAO)
        {
            _funcionarioDAO = funcionarioDAO;
        }

        //CRUD--------------------------
        public bool Adicionar(Funcionario item)
        {
            return _funcionarioDAO.Adicionar(item);
        }

        public bool Atualizar(Funcionario item)
        {
            return _funcionarioDAO.Atualizar(item);
        }

        public Funcionario? BuscarUnico(Funcionario item)
        {
            return _funcionarioDAO.BuscarUnico(item);
        }

        public List<Funcionario> BuscarVarios()
        {
            return _funcionarioDAO.BuscarVarios();
        }

        public bool Remover(Funcionario item)
        {
            return _funcionarioDAO.Remover(item);
        }
        
    }
}
