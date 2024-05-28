

using System.Text.Json.Serialization;

namespace Ecommerce.Domain.Entities
{
    public class PropertyPhoto : BaseEntity
    {
        public required string URL { get; set; }
        public required string Title { get; set; }
        public long PropertyId { get; set; }
        [JsonIgnore]
        public Property Property { get; set; } = default!;
    }
}
