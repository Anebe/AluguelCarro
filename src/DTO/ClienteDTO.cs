using CloneAluguel.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloneAluguel.DTO
{
    public class ClienteDTO : Pessoa
    {
        public int Id { get; set; }
        public string Cnh { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Renach { get; set; }
    }
}
