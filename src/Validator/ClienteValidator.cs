using AluguelCarro.src.DTO;
using System.Reflection;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AluguelCarro.src.Validator
{
    public class ClienteValidator
    {
        public static bool Validar(Cliente cliente)
        {
            List<ArgumentException?> erros = new List<ArgumentException?>();

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
                var mensagem = string.Join("\n", erros.Where(p => p != null));
                throw new ArgumentException(mensagem);
            }
        }

        public static ArgumentException? ValidarEmail(string email)
        {
            if (email == string.Empty)
            {
                return new ArgumentException("Email é obrigatório");
            }

            return null;
        }
        
        public static ArgumentException? ValidarTelefone(string telefone)
        {
            if (telefone == string.Empty)
            {
                return new ArgumentException("Telefone é obrigatório");
            }

            return null;
        }

        public static ArgumentException? ValidarCpf(string cpf)
        {
            if (cpf == string.Empty)
            {
                return new ArgumentException("Cpf é obrigatório");
            }

            return null;
        }

        public static ArgumentException? ValidarRg(string rg)
        {
            if (rg == string.Empty)
            {
                return new ArgumentException("Rg é obrigatório");
            }

            return null;
        }

        public static ArgumentException? ValidarCnh(string cnh)
        {
            if (cnh == string.Empty)
            {
                return new ArgumentException("Cnh é obrigatório");
            }

            return null;
        }

        public static ArgumentException? ValidarDataNascimento(DateTime dataNascimento)
        {
            int idade = DateTime.Now.Year - dataNascimento.Year;
            if (idade >= 18 && (dataNascimento != DateTime.MaxValue || dataNascimento != DateTime.MinValue))
            {
                return null;
            }
            else
            {
                return new ArgumentException("Menores de idade não permitidos");
            }
        }

        public static ArgumentException? ValidarRenach(string renach)
        {
            if (renach == string.Empty)
            {
                return new ArgumentException("Renach é obrigatório");
            }
            return null;
        }
   
    }
}
