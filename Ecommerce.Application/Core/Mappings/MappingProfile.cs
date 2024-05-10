using AutoMapper;
using Ecommerce.Application.Property.Responses;
using Ecommerce.Application.Users.Dtos;
using Ecommerce.Domain.Entities;


namespace Ecommerce.Application.Core.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Domain.Entities.Property, PropertyDto>().ReverseMap();
            CreateMap<User, GetUserDto>().ReverseMap();
        }
    }
}
