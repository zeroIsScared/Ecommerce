
using System.Text.Json.Serialization;


namespace Ecommerce.Domain.Entities
{
    public class Address : BaseEntity
    {   
        public string? Street {  get; set; }
        public string? HouseNumber { get; set; }
        [JsonIgnore]
        public ICollection<Property> Properties { get; set; } = default!;
        public long LocalityId { get; set; }
        public Locality Locality { get; set; } = default!;
        public string Longitude { get; set; } = default!;
        public string Latitude { get; set; } = default!;
    }
}
