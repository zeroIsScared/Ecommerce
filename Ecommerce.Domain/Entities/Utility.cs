﻿


namespace Ecommerce.Domain.Entities
{
    public class Utility : BaseEntity
    {
        public required string Name { get; set; }         
        public bool ForAppartment { get; set; }
        public bool ForLand { get; set; }
        public bool ForHouse { get; set; }
        public ICollection<PropertyUtility> Properties { get; set; } = default!;
    }
}
