using AluguelCarro.src.Entity;

namespace AluguelCarro.src.DTO
{
    public class CarroDTO
    {
        public int Id { get; private set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Grupo GrupoCarro { get; set; }
        public Filial FilialAssociado { get; set; }
    }
}