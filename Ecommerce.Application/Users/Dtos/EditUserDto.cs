

using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Users.Dtos
{
    public class EditUserDto
    {
        public long Id { get; set; }
        public required string Username { get; set; }       
        public string EditedBy { get; set; } = "Admin";
        public ICollection<Domain.Entities.Property> Properties { get; set; } = default!;
        public ICollection<UserFavorite> Favorites { get; set; } = default!;
    }
}
