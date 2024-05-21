
namespace Ecommerce.Domain.Entities
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.Now;
        public string CreatedBy { get; set; } = "Admin";
        public bool IsDeleted { get; set; }

    }
}
