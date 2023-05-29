using AluguelCarro.src.DAO.Interface;
using AluguelCarro.src.DTO;
using AluguelCarro.src.Entity;
using AluguelCarro.src.Service.Interface;

namespace AluguelCarro.src.Service
{
    internal class FilialService : IFilialService
    {
        private IFuncionarioDAO _filialDAO;

        public FilialService(IFuncionarioDAO filialDAO)
        {
            _filialDAO = filialDAO;
        }

        public bool Adicionar(FilialDTO item)
        {
            throw new NotImplementedException();
        }

        public bool Atualizar(FilialDTO item)
        {
            throw new NotImplementedException();
        }

        public FilialDTO? BuscarUnico(FilialDTO item)
        {
            throw new NotImplementedException();
        }

        public List<FilialDTO> BuscarVarios()
        {
            throw new NotImplementedException();
        }

        public bool Remover(FilialDTO item)
        {
            throw new NotImplementedException();
        }
    }
}
