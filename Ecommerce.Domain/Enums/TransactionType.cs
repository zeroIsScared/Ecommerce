
using System.ComponentModel;

namespace Ecommerce.Domain.Enums
{
     public enum TransactionType
    {
        [Description("Long term rent")]
        LongTermRent = 1,
        [Description("Rent per Month")]
        RentPerMonth,
        [Description("Rent per Day")]
        RentPerDay,
        [Description("For Sale")]
        ForSale,
        [Description("Exchange")]
        Exchange
    }
}
