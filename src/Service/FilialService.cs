using AluguelCarro.src.DAO.Interface;
using AluguelCarro.src.DTO;
using AluguelCarro.src.Service.Interface;

namespace AluguelCarro.src.Service
{
    internal class FilialService : IFilialService
    {
        private IFilialService _filialDAO;

        public FilialService(IFilialService filialDAO)
        {
            _filialDAO = filialDAO;
        }

        public bool Adicionar(Filial item)
        {
            return _filialDAO.Adicionar(item);
        }

        public bool Atualizar(Filial item)
        {
            return _filialDAO.Atualizar(item);
        }

        public Filial? BuscarUnico(Filial item)
        {
            return _filialDAO.BuscarUnico(item);
        }

        public List<Filial> BuscarVarios()
        {
            return _filialDAO.BuscarVarios();
        }

        public bool Remover(Filial item)
        {
            return _filialDAO.Remover(item);
        }
    }
}
