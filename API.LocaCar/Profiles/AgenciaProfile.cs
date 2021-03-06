using API.LocaCar.DTOs.AgenciaDtos;
using API.LocaCar.Entities;
using AutoMapper;

namespace API.LocaCar.Profiles
{
    public class AgenciaProfile : Profile
    {
        public AgenciaProfile()
        {
            CreateMap<CreateAgenciaDto, Agencia>();
            CreateMap<Agencia, ReadAgenciaDto>();
            CreateMap<Agencia, UpdateAgenciaDto>();
            CreateMap<UpdateAgenciaDto, Agencia>();

        }
    }
}
