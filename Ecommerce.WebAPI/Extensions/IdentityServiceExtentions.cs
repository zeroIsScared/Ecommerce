using Ecommerce.Domain.Entities;
using Ecommerce.Infrastructure;
using Ecommerce.WebAPI.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Ecommerce.WebAPI.Extensions
{
    public static class IdentityServiceExtentions
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services, 
            IConfiguration config) 
        {
            services.AddIdentityCore<ApplicationUser>(opt =>
            {
                opt.Password.RequireNonAlphanumeric = false;
            })
                .AddEntityFrameworkStores<EcommerceDBContext>();

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("AB98289F1F67728B517F715108A8FFF1D8D048F87957477E6C298A4FE74CFD" +
                "DE" + "AB98289F1F67728B517F715108A8FFF1D8D048F87957477E6C298A4FE74CFDDE"));

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(opt =>
                {
                    opt.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = key,
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });
            services.AddScoped<TokenService>();
            return services;
        }
    }
}
