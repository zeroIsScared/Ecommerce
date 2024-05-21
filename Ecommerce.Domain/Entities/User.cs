
namespace Ecommerce.Domain.Entities
{
    public class User : BaseEntity
    {          
        public required string Username { get; set; }       
        public required string PhoneNumber { get; set; }        
        public ICollection<Property> Properties { get; set; } = default!;
        public ICollection<UserFavorite> Favorites { get; set; } = default!;
    }
}

