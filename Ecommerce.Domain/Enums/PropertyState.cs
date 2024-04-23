

using System.ComponentModel;

namespace Ecommerce.Domain.Enums
{
    public enum PropertyState
    {
        [Description("Finished")]
        Finished = 1,
        [Description("Open plan")]
        OpenPlan,
        [Description("Cosmeticlly Renovated")]
        CosmeticallyRenovated,
        [Description("Fully Renovated")]
        FullyRenovated,
        [Description("Needs Renovation")]
        NeedsRenovation,
        [Description("Unfinished building")]
        UnfunishedBuilding      
    }
}
