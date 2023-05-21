using AluguelCarro.DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AluguelCarro.Validator
{
    public class ClienteValidator
    {
        public static bool Validar(Cliente cliente)
        {
            try
            {
                return ValidarCpf(cliente.Cpf) &&
                        ValidarCnh(cliente.Cnh) &&
                        ValidarDataNascimento(cliente.DtNascimento) &&
                        ValidarEmail(cliente.Email) &&
                        ValidarRenach(cliente.Renach) &&
                        ValidarRg(cliente.Rg) &&
                        ValidarTelefone(cliente.Telefone);
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        public static bool ValidarEmail(string email)
        {
            Regex regex = new(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$");
            if (regex.IsMatch(email))
            {
                return true;
            }
            else
            {
                throw new ArgumentException("Estrutura de Email inválido");
            }
        }

        public static bool ValidarTelefone(string telefone)
        {
            Regex regex = new(@"^\+?\d{1,3}[-.\s]?\(?\d{1,3}\)?[-.\s]?\d{1,4}[-.\s]?\d{1,4}[-.\s]?\d{1,9}$");
            if (regex.IsMatch(telefone))
            {
                return true;
            }
            else
            {
                throw new ArgumentException("Estrutura de telefone inválida");
            }
        }

        public static bool ValidarCpf(string cpf)
        {
            Regex regex = new(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$");
            if (regex.IsMatch(cpf))
            {
                return true;
            }
            else
            {
                throw new ArgumentException("Estrutura de cpf inválida");
            }
        }

        public static bool ValidarCnh(string cnh)
        {
            Regex regex = new(@"^\d{9}\d{2}$");
            if (regex.IsMatch(cnh))
            {
                return true;
            }
            else
            {
                throw new ArgumentException("Estrutura de cpf inválida");
            }
        }

        public static bool ValidarDataNascimento(DateTime dataNascimento)
        {
            int idade = DateTime.Now.Year - dataNascimento.Year;
            if (idade >= 18)
            {
                return true;
            }
            else
            {
                throw new ArgumentException("Menores de idade não permitidos");
            }
        }

        public static bool ValidarRg(string rg)
        {
            Regex regex = new(@"^\d{12}-\d{1}$");
            if (regex.IsMatch(rg))
            {
                return true;
            }
            else
            {
                throw new ArgumentException("Estrutura de rg inválida");
            }
        }

        public static bool ValidarRenach(string renach)
        {
            Regex regex = new(@"^\d{11}$");
            if (regex.IsMatch(renach))
            {
                return true;
            }
            else
            {
                throw new ArgumentException("Estrutura de renach inválida");
            }
        }
    }
}
