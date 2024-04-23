

using Ecommerce.Domain.Entities;
using Ecommerce.Infrastracture.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastracture.EntityConfigurations
{
    internal class LocalityConfiguration : BaseEntityConfiguration<Locality>
    {
        public override void Configure(EntityTypeBuilder<Locality> builder)
        {
            base.Configure(builder);

            builder.HasOne(x => x.District)
                .WithMany(x => x.Localities)
                .HasForeignKey(x => x.DistrictId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(s => s.Name)
                .HasMaxLength(EntityConstants.MaxNameLength);

            builder.Property(s => s.Region)
               .HasMaxLength(EntityConstants.MaxNameLength);
        }
    }
}
