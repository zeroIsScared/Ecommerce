

namespace Ecommerce.Domain.Entities
{
    public class Currency : BaseEntity
    {
        public string? Symbol { get; set; }
        public required string Code { get; set; }
        public ICollection<Property> Properties { get; set; } = default!;
    }
}