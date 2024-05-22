using Ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Ecommerce.Infrastracture.EntityConfigurations
{
    internal class PropertyUtilityConfiguration : BaseEntityConfiguration<PropertyUtility>
    {
        public override void Configure(EntityTypeBuilder<PropertyUtility> builder)
        {
            base.Configure(builder);         

            builder.HasOne(x => x.Utility)
                   .WithMany(x => x.Properties)
                   .HasForeignKey(x => x.UtilityId);

            builder.HasOne(x => x.Property)
                   .WithMany(x => x.Utilities)
                   .HasForeignKey(x => x.PropertyId);

            builder.HasQueryFilter(x => !x.IsDeleted);
        }
    }
}
