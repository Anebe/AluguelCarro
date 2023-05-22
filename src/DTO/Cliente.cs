using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AluguelCarro.src.DTO
{
    public class Cliente : Pessoa
    {
        public int? Id { get; set; }
        public string? Cnh { get; set; }
        public DateTime? DtNascimento { get; set; }
        public string? Renach { get; set; }


        
        /*public Cliente(string nome, string cpf, string cnh, DateTime dtNascimento, string email, string rg, string telefone, string renach) :
            base(nome, cpf, email, rg, telefone)
        {
            Cnh = cnh;
            DtNascimento = dtNascimento;
            Renach = renach;
        }

        public Cliente(int id, string nome, string cpf, string cnh, DateTime dtNascimento, string email, string rg, string telefone, string renach) :
            this(nome, cpf, cnh, dtNascimento, email, rg, telefone, renach)
        {
            Id = id;
        }*/



    }
}
