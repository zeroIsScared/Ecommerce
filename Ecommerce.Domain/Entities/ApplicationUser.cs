

using Microsoft.AspNetCore.Identity;

namespace Ecommerce.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public required string Name {get; set; }
    }
}
