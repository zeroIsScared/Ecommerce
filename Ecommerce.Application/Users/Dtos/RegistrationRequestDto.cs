

namespace Ecommerce.Application.Users.Dtos
{
    public class RegistrationRequestDto
    {
        public required string Username { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Password { get; set; }        
    }
}
