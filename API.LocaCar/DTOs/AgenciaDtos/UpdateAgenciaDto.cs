using API.LocaCar.Entities;

namespace API.LocaCar.DTOs.AgenciaDtos
{
    public class UpdateAgenciaDto
    {
        public string Nome { get; set; }
        public int Capacidade { get; set; }
        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
    }
}
