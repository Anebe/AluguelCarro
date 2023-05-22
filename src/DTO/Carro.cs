using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.DTO
{
    public class Carro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }

        [ForeignKey("id_grupo")]
        public Grupo? GrupoCarro { get; set; }
        [ForeignKey("id_filial")]
        public Filial? FilialAssociado { get; set; }
}
}
