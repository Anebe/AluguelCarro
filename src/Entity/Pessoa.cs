using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.Entity
{
    public abstract class Pessoa
    {

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Rg { get; set; }
        public string Telefone { get; set; }

        /*public Pessoa(string nome, string cpf, string email, string rg, string telefone)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Rg = rg;
            Telefone = telefone;
        }*/
    }
}
