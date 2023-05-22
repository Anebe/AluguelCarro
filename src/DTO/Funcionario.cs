using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.DTO
{

    public class Funcionario : Pessoa
    {
        [Key]
        public int? Id { get; private set; }
        public string? Cargo { get; set; }
        public double? Salario { get; private set; }
        [Column("dtContratacao")]
        public DateTime? DataContratacao { get; set; }
        [ForeignKey("filial_id")]
        public Filial? FilialAssociado { get; set; }



        /*public Funcionario(string nome, string cpf, string email, string rg, string telefone, string cargo, double salario, DateTime dataContratacao, Filial filialAssociado) :
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
        }*/
    }
}
