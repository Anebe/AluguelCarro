using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AluguelCarro.src.DTO
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Rg { get; set; }
        public string Telefone { get; set; }
        public string Cnh { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Renach { get; set; }
    }
}
