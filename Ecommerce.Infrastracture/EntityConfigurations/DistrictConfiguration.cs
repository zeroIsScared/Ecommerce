
using Ecommerce.Domain.Entities;
using Ecommerce.Infrastracture.Constants;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastracture.EntityConfigurations
{
    internal class DistrictConfiguration : BaseEntityConfiguration<District>
    {
        public override void Configure(EntityTypeBuilder<District> builder)
        {
            base.Configure(builder);

            builder.Property(s => s.Name)               
                .HasMaxLength(EntityConstants.MaxNameLength);
        }
    }
}
