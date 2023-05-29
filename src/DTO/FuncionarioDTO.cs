using CloneAluguel.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneAluguel.DTO
{

    public class FuncionarioDTO : Pessoa
    {
        public int Id { get; private set; }
        public string Cargo { get; set; }
        public decimal Salario { get; private set; }
        public DateTime DataContratacao { get; set; }
        public FilialDTO FilialAssociado { get; set; }
    }
}
