using Ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Ecommerce.Infrastracture.EntityConfigurations
{
    internal class PropertyPhotoConfiguration : BaseEntityConfiguration<PropertyPhoto>
    {
        public override void Configure(EntityTypeBuilder<PropertyPhoto> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Title)
                .HasMaxLength(Constants.EntityConstants.MaxNameLength);

            builder.HasOne(x => x.Property)
                .WithMany(x => x.Photos)
                .HasForeignKey(x => x.PropertyId);
        }
    }
}
