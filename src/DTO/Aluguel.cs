using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.DTO
{
    public class Aluguel
    {
        [Key] [ForeignKey("id_cliente")]
        public Cliente? Cliente { get; set; }

        [Key] [ForeignKey("id_carro")]
        public Carro? Carro { get; set; }
        public decimal? Total { get; set; }
        [ForeignKey("id_status")]
        public int Status { get; set; }
        [Column("dtInicio")]
        public DateTime? DataInicio { get; set; }
        [Column("dtFim")]
        public DateTime? DataFim{ get; set; }

        [ForeignKey("id_filial_devolucao")]    
        public Filial? FilialDevolucao { get; set; }

        [ForeignKey("id_filial_busca")]
        public Filial? FilialBusca { get; set; }
    }
}
