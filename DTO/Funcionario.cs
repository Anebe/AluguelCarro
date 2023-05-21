using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.DTO
{
    public class Funcionario : Pessoa
    {
        public int? Id { get; private set; }
        public string Cargo { get; set; }
        public double Salario { get; private set; }
        public DateTime DataContratacao { get; set; }
        public Filial FilialAssociado { get; set; }

        

        public Funcionario(string nome, string cpf, string email, string rg, string telefone, string cargo, double salario, DateTime dataContratacao, Filial filialAssociado) :
            base(nome, cpf, email, rg, telefone)
        {
            Cargo = cargo;
            Salario = salario;
            DataContratacao = dataContratacao;
            FilialAssociado = filialAssociado;
        }

        public Funcionario(int id, string nome, string cpf, string email, string rg, string telefone, string cargo, double salario, DateTime dataContratacao, Filial filialAssociado) :
            this(nome, cpf, email, rg, telefone, cargo, salario, dataContratacao, filialAssociado)
        {
            Id = id;
        }
    }
}
