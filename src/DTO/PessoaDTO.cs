using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.DTO
{
    public abstract class PessoaDTO
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public string Email { get; set; }
        public string Rg { get; private set; }
        public string Telefone { get; set; }


    }
}
