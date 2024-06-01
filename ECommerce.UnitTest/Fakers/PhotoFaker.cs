

using Bogus;
using Ecommerce.Domain.Entities;

namespace ECommerce.UnitTest.Fakers
{
    public sealed class PhotoFaker : Faker<PropertyPhoto>
    {
        public PhotoFaker()
        {
            RuleFor(x => x.Title, y => y.Random.Word());
            RuleFor(x => x.URL, y => "Url copy");
        }
    }
}
