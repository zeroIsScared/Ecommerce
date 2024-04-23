

using Ecommerce.Domain.Entities;
using Ecommerce.Infrastracture.Constants;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastracture.EntityConfigurations
{
    internal class CurrencyConfiguration : BaseEntityConfiguration<Currency>
    {
        public override void Configure(EntityTypeBuilder<Currency> builder)
        {
            base.Configure(builder);

            builder.Property(s => s.Symbol)
                .HasMaxLength(EntityConstants.MaxSymbolLength);

            builder.Property(s => s.Code)
               .HasMaxLength(EntityConstants.MaxCodeLength);
        }
    }
}
