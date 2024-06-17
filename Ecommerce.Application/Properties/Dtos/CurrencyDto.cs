

namespace Ecommerce.Application.Properties.Dtos
{
    public class CurrencyDto
    {
        public long Id { get; set; }
        public string? Symbol { get; set; }
        public required string Code { get; set; }
    }
}
