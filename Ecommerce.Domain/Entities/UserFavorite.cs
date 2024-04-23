


namespace Ecommerce.Domain.Entities
{
    public class UserFavorite : BaseEntity
    {
        public long UserId { get; set; }
        public User User { get; set; } = default!;
        public long PropertyId { get; set; }
        public Property Property { get; set; } = default!;
    }
}

