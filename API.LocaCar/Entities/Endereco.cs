using System.Text.Json.Serialization;

namespace API.LocaCar.Entities
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public int Numero { get; set; }
        public string CEP { get; set; }
        [JsonIgnore]
        public Agencia Agencia { get; set; }

    }
}
