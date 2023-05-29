using AluguelCarro.src.Entity;

namespace AluguelCarro.src.Service.Interface
{
    internal interface IFuncionarioService
    {
        public Funcionario Login(Login login);
    }
}