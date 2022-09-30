using APIModels.DTOS.SignUp;
using APIModels.Entities;
using AutoMapper;
using System;

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
