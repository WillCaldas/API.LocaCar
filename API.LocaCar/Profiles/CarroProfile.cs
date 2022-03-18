using API.LocaCar.DTOs.CarroDtos;
using API.LocaCar.Entities;
using AutoMapper;

namespace API.LocaCar.Profiles
{
    public class CarroProfile : Profile
    {
        public CarroProfile()
        {
            CreateMap<CreateCarroDto, Carro>();
        }
    }
}
