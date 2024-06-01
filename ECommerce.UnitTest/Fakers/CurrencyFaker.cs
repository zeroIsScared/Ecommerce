

using Bogus;
using Ecommerce.Domain.Entities;

namespace ECommerce.UnitTest.Fakers
{
    public sealed class CurrencyFaker : Faker<Currency>
    {
        public CurrencyFaker()
        {
            RuleFor(x => x.Code, y => y.Finance.Currency().Code);
            RuleFor(x => x.Symbol, y => y.Finance.Currency().Symbol);
        }
    }
}
