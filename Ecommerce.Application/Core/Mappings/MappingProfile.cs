using AutoMapper;
using Ecommerce.Application.Properties.Dtos;
using Ecommerce.Application.UserFavorites.Dtos;
using Ecommerce.Application.Users.Dtos;
using Ecommerce.Domain.Entities;
using System.Globalization;


namespace Ecommerce.Application.Core.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Property, GetPropertyDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap(); 
            CreateMap<Currency, CurrencyDto>().ReverseMap();
            CreateMap<UserFavorite, GetUserFavoritesDto>().ReverseMap();            
            CreateMap<PropertyDetail, PropertyDetailsDto>().ReverseMap();
            CreateMap<PropertyPhoto, PhotoDto>().ReverseMap();
            CreateMap<PropertyUtility, PropertyUtilityDto>().ReverseMap();
            CreateMap<Address, AddressDto>()
                .ForMember(dst => dst.LocalityName, y => y.MapFrom(src => src.Locality.Name))
                .ForMember(dst => dst.DistrictName, y => y.MapFrom(src => src.Locality.District.Name))
                .ForMember(dst => dst.LocalityRegion, y => y.MapFrom(src => src.Locality.Region))
                .ReverseMap();
            CreateMap<Property, CreatePropertyDto>().ReverseMap();
            CreateMap<Property, FavoritePropertyDto>().ReverseMap();
        }
    }
}
