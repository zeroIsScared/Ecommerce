

using Bogus;
using Ecommerce.Domain.Entities;

namespace ECommerce.UnitTest.Fakers
{
    public sealed class UserFaker : Faker<User>
    {
        public UserFaker()
        {
            RuleFor(x => x.Id, y => y.UniqueIndex);
            RuleFor(x => x.Username, y => y.Random.Word());
            RuleFor(x => x.PhoneNumber, y => y.Phone.PhoneNumber("###-###-###"));
        }       
    }
}
