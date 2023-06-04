

namespace AluguelCarro.src.DTO
{
    public class Aluguel
    {

        private Cliente cliente;
        private Carro carro;

        public int Id { get; set; }
        public int Id_cliente { get => cliente.Id; }
        public int Id_carro { get => carro.Id; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFim { get; set; }
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
    }
}
