

namespace Ecommerce.Application.Properties.Dtos
{
    public class CurrencyDto
    {
        public long CurrencyId { get; set; }
        public string? Symbol { get; set; }
        public required string Code { get; set; }
    }
}
