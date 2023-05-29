using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.DTO
{
    public class EstadoDTO
    {
        public string Descricao { get; }
        public int Id { get; }

        private EstadoDTO(string descricao, int id)
        {
            Descricao = descricao;
            Id = id;
        }

        public static readonly EstadoDTO AGENDADO = new EstadoDTO("Agendado", 1);
        public static readonly EstadoDTO ANDAMENTO = new EstadoDTO("Andamento", 2);
        public static readonly EstadoDTO FINALIZADO = new EstadoDTO("Finalizado", 3);
        public static readonly EstadoDTO CANCELADO = new EstadoDTO("Cancelado", 4);
    }
}
