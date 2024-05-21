﻿using AutoMapper;
using Ecommerce.Application.Properties.Dtos;
using Ecommerce.Application.UserFavorites.Dtos;
using Ecommerce.Application.Users.Dtos;
using Ecommerce.Domain.Entities;


namespace Ecommerce.Application.Core.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Property, GetPropertyDto>().ReverseMap();
            CreateMap<User, GetUserDto>().ReverseMap();
            CreateMap<User, GetUserDto>().ReverseMap();
            CreateMap<User, AddOrEditUserDto>().ReverseMap();
            CreateMap<User, AddOrEditUserDto>().ReverseMap();
            CreateMap<UserFavorite, GetUserFavoritesDto>().ReverseMap();
        }
    }
}
