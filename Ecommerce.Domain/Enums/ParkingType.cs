


using System.ComponentModel;

namespace Ecommerce.Domain.Enums
{
    public enum ParkingType
    {
        [Description("Covert Parking")]
        CovertParking = 1,
        [Description("Grage Parking")]
        GarageParking,
        [Description("Street Parking")]
        StreetParking,
        [Description("Underground Parking")]
        UndergroundCarParking
    }
}
