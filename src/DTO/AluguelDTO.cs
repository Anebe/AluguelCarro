using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneAluguel.DTO
{
    public class AluguelDTO
    {
        public ClienteDTO Cliente { get; set; }
        public CarroDTO Carro { get; set; }
        public EstadoDTO Estado { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public FilialDTO FilialDevolucao { get; set; }
        public FilialDTO FilialBusca { get; set; }
        public decimal Total { get; set; }
    }
}
