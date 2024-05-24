


namespace Ecommerce.Application.Properties.Dtos
{
    public class AddressDto
    {
        public string? Street { get; set; }
        public string? HouseNumber { get; set; }
        public required string LocalityName { get; set; }
        public string? LocalityRegion { get; set; }
        public required string DistrictName { get; set; }
    }
}
