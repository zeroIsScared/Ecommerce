using Ecommerce.Application.Core.Mappings;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Properties.Commands;
using Ecommerce.Application.Properties.Queries;
using Ecommerce.Domain.Entities;
using Ecommerce.Infrastracture;
using Ecommerce.Infrastructure;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;


namespace Ecommerce.WebAPI.Extensions
{
    public static class ApplicationServiceExtentions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, 
            IConfiguration config) 
        {
            services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddDbContext<EcommerceDBContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("Default"));
            });
            services.AddTransient<IRepository<Property>, EFRepository<Property>>();
            services.AddTransient<IRepository<User>, EFRepository<User>>();
            services.AddAutoMapper(typeof(MappingProfile).Assembly);
            services.AddFluentValidationAutoValidation();
            services.AddValidatorsFromAssemblyContaining<CreateProperty>();
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetListOfProperties.Handler).Assembly));
            return services;
        }
    }
}
