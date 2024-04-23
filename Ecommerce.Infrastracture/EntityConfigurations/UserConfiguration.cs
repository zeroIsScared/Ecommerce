

using Ecommerce.Domain.Entities;
using Ecommerce.Infrastracture.Constants;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastracture.EntityConfigurations
{
    internal class UserConfiguration : BaseEntityConfiguration<User> 
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Username)
                .HasMaxLength(EntityConstants.MaxNameLength);

            builder.Property(x => x.PhoneNumber)
                .IsRequired().HasMaxLength(30);
        }

    }
}
