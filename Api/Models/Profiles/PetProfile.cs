using Api.Models.Dto;
using AutoMapper;

namespace Api.Models.Profiles
{
    public class PetProfile : Profile
    {
        public PetProfile() 
        {
            CreateMap<Pet, PetDto>().ReverseMap();
        }
    }
}
