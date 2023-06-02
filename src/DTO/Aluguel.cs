

namespace AluguelCarro.src.DTO
{
    public class Aluguel
    {

        private Cliente cliente;
        private Carro carro;
        private Filial filialDevolucao;
        private Filial filialBusca;

        public int Id_cliente { get => cliente.Id; }
        public int Id_carro { get => carro.Id; }
        public Estado Id_status { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int Id_filial_devolucao { get => filialDevolucao.Id; }
        public int Id_filial_busca { get => filialBusca.Id; }
        public decimal Total { get; set; }

        public Cliente GetCliente()
        {
            return cliente;
        }
        
        public void SetCliente(Cliente cliente)
        {
            this.cliente = cliente;
        }

        public Carro getCarro()
        {
            return carro;
        }

        public void SetCarro(Carro carro)
        {
            this.carro = carro;
        }

        public Filial GetFilialDevolucao()
        {
            return filialDevolucao;
        }

        public void SetFilialDevolucao(Filial filialDevolucao)
        {
            this.filialDevolucao = filialDevolucao;
        }

        public Filial GetFilialBusca()
        {
            return filialBusca;
        }

        public void SetFilialBusca(Filial filialBusca)
        {
            this.filialBusca = filialBusca;
        }

    }
}
