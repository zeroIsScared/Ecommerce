﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

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
    }
}
