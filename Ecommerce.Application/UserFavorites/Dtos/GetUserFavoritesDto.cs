

using Ecommerce.Application.Properties.Dtos;
using Ecommerce.Application.Users.Dtos;
using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.UserFavorites.Dtos
{
    public class GetUserFavoritesDto
    {
        public long UserId { get; set; }
        public UserDto User { get; set; } = default!;
        public long PropertyId { get; set; }
        public GetPropertyDto Property { get; set; } = default!;
    }
}
