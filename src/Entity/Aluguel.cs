using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.Entity
{
    public class Aluguel
    {
        public int Cliente { get; set; }
        public int Id_carro { get; set; }
        public int id_status { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int id_filial_devolucao { get; set; }
        public int id_filial_busca { get; set; }
        public decimal Total { get; set; }
    }
}
