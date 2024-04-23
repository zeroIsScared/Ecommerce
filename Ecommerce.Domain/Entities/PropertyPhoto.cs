

namespace Ecommerce.Domain.Entities
{
    public class PropertyPhoto : BaseEntity
    {
        public required string URL { get; set; }
        public required string Title { get; set; }
        public long PropertyId { get; set; }
        public Property Property { get; set; } = default!;
    }
}
