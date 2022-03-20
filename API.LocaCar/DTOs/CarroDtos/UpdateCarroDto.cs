namespace API.LocaCar.DTOs.CarroDtos
{
    public class UpdateCarroDto
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public int AgenciaId { get; set; }
    }
}
