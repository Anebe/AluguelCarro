using AluguelCarro.src.DTO;
using AluguelCarro.src.Entity;
using AluguelCarro.src.Util;

namespace AluguelCarro.src.Service.Interface
{
    internal interface IFuncionarioService : IGenericCRUD<FuncionarioDTO>
    {
        public Funcionario Login(Login login);
    }
}