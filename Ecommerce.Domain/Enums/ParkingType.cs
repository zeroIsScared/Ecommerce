


using System.ComponentModel;

namespace Ecommerce.Domain.Enums
{
    public enum ParkingType
    {
        [Description("Covert Parking")]
        CovertParking = 1,
        [Description("Garage Parking")]
        GarageParking,
        [Description("Street Parking")]
        StreetParking,
        [Description("Underground Parking")]
        UndergroundCarParking
    }
}
