using API.LocaCar.Entities;

namespace API.LocaCar.DTOs.AgenciaDtos
{
    public class CreateAgenciaDto
    {
        public string Nome { get; set; }
        public int Capacidade { get; set; }
        public Endereco Endereco { get; set; }
    }
}
