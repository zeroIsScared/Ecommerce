

using Bogus;
using Ecommerce.Domain.Entities;


namespace ECommerce.UnitTest.Fakers
{
    public class UtilityFaker : Faker<Utility>
    {
        public UtilityFaker()
        {
            RuleFor(x => x.Name, y => y.Random.Word());
        }
    }
}
