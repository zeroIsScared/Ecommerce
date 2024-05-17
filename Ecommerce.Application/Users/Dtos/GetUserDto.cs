



using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Users.Dtos
{
    public class GetUserDto
    {
        public long Id { get; set; }             
        public required string Username { get; set; }
        public required string PhoneNumber { get; set; }
        public ICollection<Property> Properties { get; set; } = default!;
        public ICollection<UserFavorite> Favorites { get; set; } = default!;
    }
}
