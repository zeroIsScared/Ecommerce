
namespace Ecommerce.Application.Property.Responses
{
    public class PropertyDto
    {    
        public required string Title { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
    }
}
