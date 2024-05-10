

using Ecommerce.Application.Property.Responses;

namespace Ecommerce.Application.Users.Dtos
{
    public class GetUserDto
    {
        public long Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }        
        public required string Username { get; set; }
        public required string PhoneNumber { get; set; }
        public ICollection<PropertyDto> Properties { get; set; } = default!;
        public ICollection<PropertyDto> Favorites { get; set; } = default!;
    }
}
