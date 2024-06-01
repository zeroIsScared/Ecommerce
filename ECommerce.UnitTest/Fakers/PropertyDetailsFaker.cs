

using Bogus;
using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Enums;

namespace ECommerce.UnitTest.Fakers
{
    public sealed class PropertyDetailsFaker : Faker<PropertyDetail>
    {
        public PropertyDetailsFaker()
        {
            RuleFor(x => x.LivingArea, y => y.Random.Decimal().ToString());
            RuleFor(x => x.Floor, y => y.Random.Number().ToString());
            RuleFor(x => x.RoomNumber, y => y.Random.Number());
            RuleFor(x => x.State, y => y.PickRandom<PropertyState>());
            RuleFor(x => x.AuthorType, y => y.PickRandom<AuthorType>());
            RuleFor(x => x.BuildingType, y => y.PickRandom<BuildingType>());
            RuleFor(x => x.ParkingType, y => y.PickRandom<ParkingType>());
            RuleFor(x => x.LandType, y => y.PickRandom<LandType>());
        }
    }
}
