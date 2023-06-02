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
        private Grupo GrupoCarro;
        private Filial FilialAssociado;

        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public int Id_Grupo { get => GrupoCarro.Id; }
        public int Id_Filial { get => FilialAssociado.Id; }

        public void setGrupoCarro(Grupo GrupoCarro)
        {
            this.GrupoCarro = GrupoCarro;
        }

        public void setFilialAssociado(Filial FilialAssociado)
        {
            this.FilialAssociado = FilialAssociado;
        }

        public Grupo GetGrupoCarro()
        {
            return GrupoCarro;
        }

        public Filial GetFilialAssociado()
        {
            return FilialAssociado;
        }
    }
}
