using AluguelCarro.src.DTO;
using AluguelCarro.src.Util;

namespace AluguelCarro.src.DAO.Interface
{
    internal interface IAluguelDAO : IGenericCRUD<Aluguel>
    {
        public List<Aluguel> BuscarVarios(Aluguel filtro);
    }
}
