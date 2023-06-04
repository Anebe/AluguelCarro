using AluguelCarro.src.DTO;
using System.Text.RegularExpressions;

namespace AluguelCarro.src.Validator
{
    public class ClienteValidator
    {
        public static bool Validar(Cliente cliente)
        {
            List<ArgumentException> erros = new List<ArgumentException>();

            erros.Add(ValidarCnh(cliente.Cnh));
            erros.Add(ValidarDataNascimento(cliente.DtNascimento));
            erros.Add(ValidarRenach(cliente.Renach));
            erros.Add(ValidarEmail(cliente.Email));
            erros.Add(ValidarTelefone(cliente.Telefone));
            erros.Add(ValidarCpf(cliente.Cpf));
            erros.Add(ValidarRg(cliente.Rg));


            if (erros.Count == 0)
            {
                return true;
            }
            else
            {
                var mensagem = string.Join("\n", erros);
                throw new ArgumentException(mensagem);
            }
        }

        public static ArgumentException ValidarEmail(string email)
        {
            Regex regex = new(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$");

            if (regex.IsMatch(email))
            {
                return null;
            }
            else
            {
                throw new ArgumentException("Estrutura de Email inválido");
            }

        }

        public static ArgumentException ValidarTelefone(string telefone)
        {
            Regex regex = new(@"^\(?\d{1,3}\)?[-.\s]?\d{1,4}[-.\s]?\d{1,4}[-.\s]?\d{1,9}$");
            if (regex.IsMatch(telefone))
            {
                return null;
            }
            else
            {
                throw new ArgumentException("Estrutura de telefone inválida");
            }
        }

        public static ArgumentException ValidarCpf(string cpf)
        {
            Regex regex = new(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$");
            if (regex.IsMatch(cpf))
            {
                return null;
            }
            else
            {
                throw new ArgumentException("Estrutura de cpf inválida");
            }
        }

        public static ArgumentException ValidarRg(string rg)
        {
            Regex regex = new(@"^\d{12}-\d{1}$");
            if (regex.IsMatch(rg))
            {
                return null;
            }
            else
            {
                throw new ArgumentException("Estrutura de rg inválida");
            }
        }

        public static ArgumentException ValidarCnh(string cnh)
        {
            Regex regex = new(@"^\d{11}$");
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
