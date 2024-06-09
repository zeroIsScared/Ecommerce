

using Ecommerce.Application.Properties.Dtos;
namespace Ecommerce.Application.UserFavorites.Dtos
{
    public class GetUserFavoritesDto
    {
        public long UserId { get; set; }       
        public long PropertyId { get; set; }
        public GetPropertyDto Property { get; set; } = default!;
    }
}
