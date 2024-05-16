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
            CreateMap<User, GetUserDto>()
                .ForMember(
                destinationMember => destinationMember.Id,
                memberOptions => memberOptions.MapFrom(x => x.Id))
                .ForMember(
                destinationMember => destinationMember.Username,
                memberOptions => memberOptions.MapFrom(x => x.Username))
                .ForMember(
                destinationMember => destinationMember.PhoneNumber,
                memberOptions => memberOptions.MapFrom(x => x.PhoneNumber));

            CreateMap<CreateUserDto, User>()
                .ForMember(
                destinationMember => destinationMember.Username,
                memberOptions => memberOptions.MapFrom(x => x.Username))
                .ForMember(
                destinationMember => destinationMember.PhoneNumber,
                memberOptions => memberOptions.MapFrom(x => x.PhoneNumber));
        }
    }
}
