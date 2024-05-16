

using Ecommerce.Application.Property.Responses;

namespace Ecommerce.Application.Users.Dtos
{
    public class GetUserDto
    {
        public long Id { get; set; }             
        public required string Username { get; set; }
        public required string PhoneNumber { get; set; }       
    }
}
