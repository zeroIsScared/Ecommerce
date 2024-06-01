

using Bogus;
using Ecommerce.Domain.Entities;

namespace ECommerce.UnitTest.Fakers
{
    public sealed class DistrictFaker : Faker<District>
    {
        public DistrictFaker()
        {
            RuleFor(x => x.Name, y => y.Random.Word());
        }
    }
}
