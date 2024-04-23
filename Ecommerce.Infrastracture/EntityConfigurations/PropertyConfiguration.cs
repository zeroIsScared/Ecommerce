using Ecommerce.Domain.Entities;
using Ecommerce.Infrastracture.Constants;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Ecommerce.Infrastracture.EntityConfigurations
{
    internal class PropertyConfiguration :BaseEntityConfiguration <Property>
    {
        public override void Configure(EntityTypeBuilder<Property> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(EntityConstants.MaxNameLength);

            builder.Property(x => x.Description)
                .HasMaxLength(EntityConstants.MaxDescriptionLength);

            builder.Property(x => x.Price)
                .IsRequired();

            builder.HasOne(s => s.Currency)
                .WithMany(g => g.Properties)
                .HasForeignKey(s => s.CurrencyId);

            builder.HasOne(s => s.User)
                .WithMany(g => g.Properties)
                .HasForeignKey(s => s.UserId);

            builder.HasOne(s => s.Details)
                .WithOne(g => g.Property)
                .HasForeignKey<PropertyDetail>(s => s.PropertyId);

            builder.HasOne(s => s.Address)
                .WithMany(g => g.Properties)
                .HasForeignKey(s => s.AddressId);
        }
    }
}
