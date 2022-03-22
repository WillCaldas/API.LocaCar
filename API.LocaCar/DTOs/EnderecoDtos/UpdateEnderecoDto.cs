namespace API.LocaCar.DTOs.EnderecoDtos
{
    public class UpdateEnderecoDto
    {
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public int Numero { get; set; }
        public string Cep{ get; set; }
    }
}
