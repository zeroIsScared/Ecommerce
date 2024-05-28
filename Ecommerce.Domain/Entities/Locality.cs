using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Entities
{
    public class Locality : BaseEntity
    {    
        public required string Name { get; set; }
        public string? Region {  get; set; }
        public long DistrictId { get; set; }
        public District District { get; set; } = default!;
        [JsonIgnore]
        public ICollection<Address> Addresses { get; set; } = default!;
    }
}
