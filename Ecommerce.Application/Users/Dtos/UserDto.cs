



using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Users.Dtos
{
    public class UserDto
    {
        public long? Id { get; set; }             
        public required string Username { get; set; }
        public required string PhoneNumber { get; set; }        
    }
}
