

namespace AluguelCarro.src.DTO
{
    public class AluguelDTO
    {

        private ClienteDTO cliente;
        private CarroDTO carro;
        private FilialDTO filialDevolucao;
        private FilialDTO filialBusca;

        public int Id_cliente { get => cliente.Id; }
        public int Id_carro { get => carro.Id; }
        public EstadoDTO Id_status { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int Id_filial_devolucao { get => filialDevolucao.Id; }
        public int Id_filial_busca { get => filialBusca.Id; }
        public decimal Total { get; set; }

        public ClienteDTO GetCliente()
        {
            return cliente;
        }
         public void SetCliente(ClienteDTO cliente)
        {
            this.cliente = cliente;
        }

        public CarroDTO getCarro()
        {
            return carro;
        }

        public void SetCarro(CarroDTO carro)
        {
            this.carro = carro;
        }

        public FilialDTO GetFilialDevolucao()
        {
            return filialDevolucao;
        }

        public void SetFilialDevolucao(FilialDTO filialDevolucao)
        {
            this.filialDevolucao = filialDevolucao;
        }

        public FilialDTO GetFilialBusca()
        {
            return filialBusca;
        }

        public void SetFilialBusca(FilialDTO filialBusca)
        {
            this.filialBusca = filialBusca;
        }

    }
}
