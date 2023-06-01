using AluguelCarro.src.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AluguelCarro.src.Validator
{
    internal class PessoaValidator
    {
        public static bool Validar(Pessoa cliente)
        {
            List<ArgumentException> erros = new List<ArgumentException>();

            erros.Add(ValidarCpf(cliente.Cpf));
            erros.Add(ValidarEmail(cliente.Email));
            erros.Add(ValidarRg(cliente.Rg));
            erros.Add(ValidarTelefone(cliente.Telefone));

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
            Regex regex = new(@"^\+?\d{1,3}[-.\s]?\(?\d{1,3}\)?[-.\s]?\d{1,4}[-.\s]?\d{1,4}[-.\s]?\d{1,9}$");
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


    }
}
