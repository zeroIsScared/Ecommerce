
namespace Ecommerce.Domain.Entities
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public string CreatedBy { get; set; } = "Admin";

    }
}
