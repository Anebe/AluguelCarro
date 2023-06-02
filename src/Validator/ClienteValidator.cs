using AluguelCarro.src.DTO;
using System.Text.RegularExpressions;

namespace AluguelCarro.src.Validator
{
    public class ClienteValidator
    {
        public static bool Validar(Cliente cliente)
        {
            List<ArgumentException> erros = new List<ArgumentException>();

            try
            {
                PessoaValidator.Validar(cliente);
            }
            catch (ArgumentException e)
            {
                erros.Add(e);
            }

            erros.Add(ValidarCnh(cliente.Cnh));
            erros.Add(ValidarDataNascimento(cliente.DtNascimento));
            erros.Add(ValidarRenach(cliente.Renach));
            

            if(erros.Count == 0)
            {
                return true;
            }
            else
            {
                var mensagem = string.Join("\n", erros);
                throw new ArgumentException(mensagem);
            }
        }

        
        public static ArgumentException ValidarCnh(string cnh)
        {
            Regex regex = new(@"^\d{9}\d{2}$");
            if (regex.IsMatch(cnh))
            {
                return null;
            }
            else
            {
                throw new ArgumentException("Estrutura de cpf inválida");
            }
        }

        public static ArgumentException ValidarDataNascimento(DateTime dataNascimento)
        {
            int idade = DateTime.Now.Year - dataNascimento.Year;
            if (idade >= 18 && (dataNascimento != DateTime.MaxValue || dataNascimento != DateTime.MinValue))
            {
                return null;
            }
            else
            {
                throw new ArgumentException("Menores de idade não permitidos");
            }
        }

        public static ArgumentException ValidarRenach(string renach)
        {
            Regex regex = new(@"^\d{11}$");
            if (regex.IsMatch(renach))
            {
                return null;
            }
            else
            {
                throw new ArgumentException("Estrutura de renach inválida");
            }
        }
    }
}
