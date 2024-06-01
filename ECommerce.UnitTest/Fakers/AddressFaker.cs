

using Bogus;
using Ecommerce.Domain.Entities;

namespace ECommerce.UnitTest.Fakers
{
    internal class AddressFaker : Faker<Address>
    {
        public AddressFaker() 
        {
            RuleFor(x => x.Street, y => y.Random.Words());
            RuleFor(x => x.HouseNumber, y => y.Random.Number().ToString());
            RuleFor(x => x.Locality, Y => new LocalityFaker().Generate());
        }
    }
}
