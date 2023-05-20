using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AluguelCarro.DTO
{

    public class Cliente
    {
        public int? Id { get; private set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Cnh { get; set; }
        public DateTime? DtNascimento { get; set; }
        public string? Email { get; set; }
        public string? Rg { get; set; }
        public string? Telefone { get; set; }
        public string? Renach { get; set; }
        

        public Cliente(string nome, string cpf, string cnh, DateTime dtNascimento, string email, string rg, string telefone, string renach)
        {
            Nome = nome;
            Cpf = cpf;
            Cnh = cnh;
            DtNascimento = dtNascimento;
            Email = email;
            Rg = rg;
            Telefone = telefone;
            Renach = renach;
        }

        public Cliente(int id, string nome, string cpf, string cnh, DateTime dtNascimento, string email, string rg, string telefone, string renach): this(nome, cpf, cnh, dtNascimento, email, rg, telefone, renach)
        {
            Id = id;
        }



    }
}
