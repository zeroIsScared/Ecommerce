﻿using Ecommerce.Application.Core.Mappings;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Properties.Commands;
using Ecommerce.Application.Properties.Queries;
using Ecommerce.Application.Services;
using Ecommerce.Domain.Entities;
using Ecommerce.Infrastracture;
using Ecommerce.Infrastructure;
using Ecommerce.WebAPI.Exceptions;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;


namespace Ecommerce.WebAPI.Extensions
{
    public static class ApplicationServiceExtentions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,
            IConfiguration config)
        {
            services.AddControllers()
                .AddJsonOptions(opt =>
                {
                    opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
                });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(opt =>
            {
                opt.SwaggerDoc("v1", new OpenApiInfo { Title = "EcommerceAPI", Version = "v1" });
                opt.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please enter token",
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    BearerFormat = "JWT",
                    Scheme = "bearer"
                });

                opt.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type=ReferenceType.SecurityScheme,
                            Id="Bearer"
                        }
                    },
                    new string[]{}
                }
            });
            });
            services.AddExceptionHandler<AppExceptionHandler>();
            services.AddDbContext<EcommerceDBContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("Default"));
            });           
            services.AddAuthorization();
            services.AddTransient<IRepository<Property>, EFRepository<Property>>();
            services.AddTransient<IRepository<User>, EFRepository<User>>();
            services.AddTransient<IRepository<PropertyDetail>, EFRepository<PropertyDetail>>();
            services.AddTransient<IRepository<PropertyUtility>, EFRepository<PropertyUtility>>();
            services.AddTransient<IRepository<UserFavorite>, EFRepository<UserFavorite>>();
            services.AddTransient<IRepository<Utility>, EFRepository<Utility>>();
            services.AddTransient<IRepository<Locality>, EFRepository<Locality>>();
            services.AddTransient<IRepository<District>, EFRepository<District>>();
            services.AddTransient<IUnitOfWork,UnitOfWork>();
            services.AddScoped<IDirectionService, DirectionService>();
            services.AddAutoMapper(typeof(MappingProfile).Assembly);
            services.AddFluentValidationAutoValidation();
            services.AddValidatorsFromAssemblyContaining<CreateProperty>();
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetListOfProperties.Handler).Assembly));
            return services;
        }
    }
}
