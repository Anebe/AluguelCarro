using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.Entity
{
    public class Estado
    {
        public string Descricao { get; }
        public int Id { get; }

        private Estado(string descricao, int id)
        {
            Descricao = descricao;
            Id = id;
        }

        public static readonly Estado AGENDADO = new Estado("Agendado", 1);
        public static readonly Estado ANDAMENTO = new Estado("Andamento", 2);
        public static readonly Estado FINALIZADO = new Estado("Finalizado", 3);
        public static readonly Estado CANCELADO = new Estado("Cancelado", 4);
    }
}
