
using Bogus;
using Ecommerce.Domain.Entities;

namespace ECommerce.UnitTest.Fakers
{
    public sealed class LocalityFaker : Faker<Locality>
    {
        public LocalityFaker() 
        {
            RuleFor(x => x.Name, y => y.Random.Word());
            RuleFor(x => x.Region, y => y.Random.Word());
            RuleFor(x => x.District, y => new DistrictFaker().Generate());
        }
    }
}
