

namespace Ecommerce.Domain.Entities
{
    public class District : BaseEntity
    {
        public required string Name { get; set; }
        public ICollection<Locality> Localities { get; set; } = default!;
    }
}
