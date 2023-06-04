using System;


namespace AluguelCarro.src.DTO.VO
{
    public class AluguelVO
    {
        public int Id { get; set; }
        public int Id_cliente { get; set; }
        public string Cpf { get; set; }
        public int Id_carro { get; set; }
        public string Placa { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public double Total { get; }
    }
}
