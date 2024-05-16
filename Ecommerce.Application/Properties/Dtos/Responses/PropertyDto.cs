namespace Ecommerce.Application.Properties.Dtos.Responses
{
    public class PropertyDto
    {
        public required string Title { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
    }
}
