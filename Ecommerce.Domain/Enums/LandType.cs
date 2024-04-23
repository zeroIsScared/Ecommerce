

using System.ComponentModel;

namespace Ecommerce.Domain.Enums
{
    public enum LandType
    {
        [Description("Agricultural land")]
        AgriculturalLand = 1,
        [Description("Residential land")]
        ResidentialLand,
        [Description("Industrial land")]
        IndustrialLand,
        [Description("Coastal land")]
        CoastalLands
    }
}
