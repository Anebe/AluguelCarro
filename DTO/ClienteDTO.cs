using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.DTO
{
    public class ClienteDTO
    {
        public int id { get; private set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string cnh { get; set; }
        public DateTime dtNascimento { get; set; }
        public string email { get; set; }
        public string rg { get; set; }
        public string telefone { get; set; }
        public string renach { get; set; }

        public ClienteDTO(string nome, string cpf, string cnh, DateTime dtNascimento, string email, string rg, string telefone, string renach, int id = 0)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.cnh = cnh;
            this.dtNascimento = dtNascimento;
            this.email = email;
            this.rg = rg;
            this.telefone = telefone;
            this.renach = renach;
        }
    }
}
