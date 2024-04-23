


namespace Ecommerce.Domain.Entities
{
    public class Utility : BaseEntity
    {
        public required string Name { get; set; }         
        public bool ForAppartments { get; set; }
        public bool ForLands { get; set; }
        public bool ForHouses { get; set; }
        public ICollection<PropertyUtility> Properties { get; set; } = default!;
    }
}
