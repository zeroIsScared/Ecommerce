using AutoMapper;
using Ecommerce.Application.Districts.Dtos;
using Ecommerce.Application.Localities.Dtos;
using Ecommerce.Application.Properties.Dtos;
using Ecommerce.Application.UserFavorites.Dtos;
using Ecommerce.Application.Users.Dtos;
using Ecommerce.Application.Utilities.Dtos;
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
            CreateMap<Utility, GetUtilityDto>().ReverseMap();
            CreateMap<District, GetDistrictDto>().ReverseMap();
            CreateMap<Locality, GetLocalityDto>().ReverseMap();
            CreateMap<PropertyUtility, PropertyUtilityDto>().ReverseMap();
            CreateMap<Address, GetAddressDto>()
                .ForMember(dst => dst.LocalityName, y => y.MapFrom(src => src.Locality.Name))
                .ForMember(dst => dst.DistrictName, y => y.MapFrom(src => src.Locality.District.Name))
                .ForMember(dst => dst.LocalityRegion, y => y.MapFrom(src => src.Locality.Region));                
            CreateMap<Property, CreateOrUpdatePropertyDto>().ReverseMap();
            CreateMap<Property, FavoritePropertyDto>().ReverseMap();
            CreateMap<AddAddressDto, Address>()
                .ForMember(dst => dst.Street, y => y.MapFrom(src => src.Street))
                .ForMember(dst => dst.HouseNumber, y => y.MapFrom(src => src.HouseNumber))
                .ForMember(dst => dst.LocalityId, y => y.MapFrom(src => src.LocalityId)).ReverseMap();
        }
    }
}
