using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.DTO
{
    public class ClienteDTO : PessoaDTO
    {
        public int Id { get; private set; }
        public string Cnh { get; private set; }
        public DateTime DtNascimento { get; set; }
        public string Renach { get; set; }
    }
}
