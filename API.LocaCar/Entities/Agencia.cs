using System.Collections.Generic;

namespace API.LocaCar.Entities
{
    public class Agencia
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Capacidade { get; set; }
        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
        public List<Carro> Carros { get; set; }


    }
}
