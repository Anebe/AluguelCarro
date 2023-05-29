using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.DTO
{

    public class FuncionarioDTO : Pessoa
    {
        private FilialDTO filialAssociado;

        public int Id { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataContratacao { get; set; }
        public int Filial_id { get; set; }
        
        public FilialDTO GetFilial() { return filialAssociado; }
        public void SetFilial(FilialDTO filial) { this.filialAssociado = filial;  }
    }
}
