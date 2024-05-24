using Ecommerce.Application.Users.Dtos;
using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Enums;

namespace Ecommerce.Application.Properties.Dtos
{
    public class GetPropertyDto
    {       
        public required string Title { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public PropertyCategory Category { get; set; }
        public TransactionType TransactionType { get; set; }
        public string Currency { get; set; } = default!;
        public UserDto User { get; set; } = default!;
        public PropertyDetail Details { get; set; } = default!;       
        public Address Address { get; set; } = default!;
        public ICollection<PropertyUtility> Utilities { get; set; } = default!;      
        public ICollection<PropertyPhoto> Photos { get; set; } = default!;
    }
}
