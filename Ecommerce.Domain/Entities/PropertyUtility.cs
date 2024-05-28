


using System.Text.Json.Serialization;

namespace Ecommerce.Domain.Entities
{
    public class PropertyUtility : BaseEntity
    {
        public long PropertyId { get; set; }
        [JsonIgnore]
        public Property Property { get; set; } = default!;
        public long UtilityId { get; set; }      
        public Utility Utility { get; set; } = default!;
    }
}
