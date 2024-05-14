
namespace Ecommerce.Application.Users.Dtos
{
    public class CreateUserDto
    {
        public required string Username { get; set; }
        public required string PhoneNumber { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public string CreatedBy { get; set; } = "Admin";
    }
}
