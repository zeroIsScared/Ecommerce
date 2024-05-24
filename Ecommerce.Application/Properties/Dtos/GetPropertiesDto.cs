

using Ecommerce.Application.Users.Dtos;
using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Enums;

namespace Ecommerce.Application.Properties.Dtos
{
    public class GetPropertiesDto
    {
        public long Id { get; set; }
        public required string Title { get; set; }        
        public decimal Price { get; set; }
        public string Currency { get; set; } = default!;
       public string PhotoURL { get; set; } =default!;
    }
}
