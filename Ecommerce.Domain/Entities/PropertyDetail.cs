
using Ecommerce.Domain.Enums;


namespace Ecommerce.Domain.Entities
{
    public class PropertyDetail : BaseEntity
    {           
        public string? LivingArea {  get; set; } = default!;               
        public string? Floor {  get; set; }
        public int? RoomNumber { get; set; }
        public int? FloorsNumber { get; set; }
        public PropertyState? State { get; set; }
        public AuthorType? AuthorType { get; set; }
        public BuildingType? BuildingType { get; set; } 
        public ParkingType? ParkingType { get; set; }
        public LandType? LandType { get; set; }
        public long PropertyId { get; set; }
        public Property Property { get; set; } = default!;
    }
}