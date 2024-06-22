


namespace Ecommerce.Application.Properties.Dtos
{
    public class GetAddressDto
    {
        public long Id { get; set; }
        public string? Street { get; set; }
        public string? HouseNumber { get; set; }
        public string Longitude { get; set; } = default!;
        public string Latitude { get; set; } = default!;
        public required string LocalityName { get; set; }
        public string? LocalityRegion { get; set; }
        public required string DistrictName { get; set; }      
    }
}
