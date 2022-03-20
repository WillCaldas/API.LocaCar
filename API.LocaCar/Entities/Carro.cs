using System.Text.Json.Serialization;

namespace API.LocaCar.Entities
{
    public class Carro
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public int AgenciaId { get; set; }
        public Agencia Agencia { get; set; }
    }
}
