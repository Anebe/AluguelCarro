using AluguelCarro.src.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AluguelCarro.src.DTO
{
    public class ClienteDTO : Pessoa
    {
        public int Id { get; set; }
        public string Cnh { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Renach { get; set; }
    }
}
