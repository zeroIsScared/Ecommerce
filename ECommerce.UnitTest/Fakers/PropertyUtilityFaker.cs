

using Bogus;
using Ecommerce.Domain.Entities;

namespace ECommerce.UnitTest.Fakers
{
    public class PropertyUtilityFaker :Faker<PropertyUtility>
    {
        public PropertyUtilityFaker() 
        {
            RuleFor(x => x.PropertyId, y => y.UniqueIndex);
            RuleFor(x => x.UtilityId, y => y.UniqueIndex);
            RuleFor(x => x.Utility, y => new UtilityFaker().Generate());
        }      
    }
}
