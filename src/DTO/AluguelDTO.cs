using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AluguelCarro.src.Interface;

namespace AluguelCarro.src.DTO
{
    public class AluguelDTO
    {
        public ClienteDTO Cliente { get; private set; }
        public CarroDTO Carro { get; set; }
        public int Status { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        //public FilialDTO FilialDevolucao { get; set; }
        //public FilialDTO FilialBusca { get; set; }
        public decimal Total { get; private set; }

        
    }
}
