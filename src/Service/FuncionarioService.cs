using AluguelCarro.src.DAO.Interface;
using AluguelCarro.src.DTO;
using AluguelCarro.src.Service.Interface;

namespace AluguelCarro.src.Service
{
    internal class FuncionarioService : IFuncionarioService
    {
        private IFuncionarioDAO _funcionarioDAO;
        private IFilialDAO _filialDAO;
        public FuncionarioService(IFuncionarioDAO funcionarioDAO, IFilialDAO filialDAO)
        {
            _funcionarioDAO = funcionarioDAO;
            _filialDAO = filialDAO;
        }

        //CRUD--------------------------
        public bool Adicionar(FuncionarioDTO item)
        {

            return _funcionarioDAO.Adicionar(item);
        }

        public bool Atualizar(FuncionarioDTO item)
        {
            throw new NotImplementedException();
        }

        public FuncionarioDTO? BuscarUnico(FuncionarioDTO item)
        {
            throw new NotImplementedException();
        }

        public List<FuncionarioDTO> BuscarVarios()
        {
            throw new NotImplementedException();
        }



        public bool Remover(FuncionarioDTO item)
        {
            throw new NotImplementedException();
        }
        
    }
}
