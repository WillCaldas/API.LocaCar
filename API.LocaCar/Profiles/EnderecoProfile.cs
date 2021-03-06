using API.LocaCar.DTOs.EnderecoDtos;
using API.LocaCar.Entities;
using AutoMapper;

namespace API.LocaCar.Profiles
{
    public class EnderecoProfile : Profile
    {
        public EnderecoProfile()
        {
            CreateMap<CreateEnderecoDto, Endereco>();
            CreateMap<Endereco, ReadEnderecoDto>();
            CreateMap<Endereco, UpdateEnderecoDto>();
            CreateMap<UpdateEnderecoDto, Endereco>();
        }
    }
}
