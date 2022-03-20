using API.LocaCar.Entities;

namespace API.LocaCar.DTOs.AgenciaDtos
{
    public class ReadAgenciaDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Capacidade { get; set; }        
        public Endereco Endereco { get; set; }
    }
}
