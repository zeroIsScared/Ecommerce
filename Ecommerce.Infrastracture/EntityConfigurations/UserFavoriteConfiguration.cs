

using Ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastracture.EntityConfigurations
{
    internal class UserFavoriteConfiguration : BaseEntityConfiguration<UserFavorite>
    {
        public override void Configure(EntityTypeBuilder<UserFavorite> builder)
        {
            base.Configure(builder);

            builder.HasOne(x => x.User)
                   .WithMany(x => x.Favorites)
                   .HasForeignKey(x => x.UserId);             

            builder.HasOne(x => x.Property)
                   .WithMany(x => x.Favorites)
                   .HasForeignKey(x => x.PropertyId);
                  
        }
    }
}
