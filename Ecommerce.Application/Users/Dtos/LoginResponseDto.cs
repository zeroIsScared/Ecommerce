

using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Users.Dtos
{
    public class LoginResponseDto
    {
        public User User { get; set; }
        public string Token { get; set; }
    }
}
