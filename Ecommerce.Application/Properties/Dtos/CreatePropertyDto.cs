

using Ecommerce.Application.Users.Dtos;
using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Enums;

namespace Ecommerce.Application.Properties.Dtos
{
    public class CreatePropertyDto
    {
        public long? Id { get; set; }
        public string Title { get; set; } = default!;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public PropertyCategory Category { get; set; }
        public TransactionType TransactionType { get; set; }
        public long CurrencyId { get; set; }
        public long UserId { get; set; }
        public PropertyDetailsDto Details { get; set; } = default!;       
        public AddressDto Address { get; set; } = default!;
        public ICollection<PropertyUtilityDto> Utilities { get; set; } = default!;        
        public ICollection<PhotoDto> Photos { get; set; } = default!;
    }
}
