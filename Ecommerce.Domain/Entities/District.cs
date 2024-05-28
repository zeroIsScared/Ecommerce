

using System.Text.Json.Serialization;

namespace Ecommerce.Domain.Entities
{
    public class District : BaseEntity
    {
        public required string Name { get; set; }
        [JsonIgnore]
        public ICollection<Locality> Localities { get; set; } = default!;
    }
}
