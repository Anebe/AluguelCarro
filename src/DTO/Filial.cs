using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.DTO
{
    public class Filial
    {
        public int? Id { get; set; }
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public string? Telefone { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }

        
        
        /*public Filial(int id, string nome, string endereco, string telefone, string cidade, string estado) :
            this(nome, endereco, telefone, cidade, estado)
        {
            Id = id;
        }
        public Filial(string nome, string endereco, string telefone, string cidade, string estado)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Cidade = cidade;
            Estado = estado;
        }*/
    }
}
