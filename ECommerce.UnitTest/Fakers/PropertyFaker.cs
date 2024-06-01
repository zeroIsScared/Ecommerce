

using Bogus;
using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Enums;

namespace ECommerce.UnitTest.Fakers
{
    public sealed class PropertyFaker : Faker<Property> 
    {
        public PropertyFaker()
        {
            RuleFor(x => x.Id, y => y.UniqueIndex);
            RuleFor(x => x.Title, y => y.Random.Word());
            RuleFor(x => x.Price, y => y.Random.Decimal());
            RuleFor(x => x.Description, y => y.Random.Words());
            RuleFor(x => x.Category, y => y.PickRandom<PropertyCategory>());
            RuleFor(x => x.User, new UserFaker().Generate());
            RuleFor(x => x.Currency, new CurrencyFaker().Generate());
            RuleFor(x => x.Photos, new PhotoFaker().Generate(2));
            RuleFor(x => x.IsDeleted, y => y.Equals(false));
        }
    }
}
