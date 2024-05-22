

using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Enums;

namespace Ecommerce.Application.Properties.Dtos
{
    public class CreatePropertyDto
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public PropertyCategory Category { get; set; }
        public TransactionType TransactionType { get; set; }
        public long CurrencyId { get; set; }
        public Currency Currency { get; set; } = default!;
        public long UserId { get; set; }        
        public PropertyDetail Details { get; set; } = default!;       
        public Address Address { get; set; } = default!;
        public ICollection<PropertyUtility> Utilities { get; set; } = default!;        
        public ICollection<PropertyPhoto> Photos { get; set; } = default!;
    }
}
