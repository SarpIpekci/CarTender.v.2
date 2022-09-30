using APIModels.DTOS.SignUp;
using APIModels.Entities;
using AutoMapper;

namespace APIMapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, RegisterDTO>();
            CreateMap<RegisterDTO, User>();
        }
    }
}
