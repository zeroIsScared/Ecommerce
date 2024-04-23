
using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Enums;
using Ecommerce.Infrastracture.Constants;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastracture.EntityConfigurations
{
    internal class PopertyDetailConfiguration : BaseEntityConfiguration<PropertyDetail>
    {
        public override void Configure(EntityTypeBuilder<PropertyDetail> builder)
        {
            base.Configure(builder);        

            builder.Property(x => x.LivingArea)
                .HasMaxLength(EntityConstants.MaxDimensionsLength);

            builder.Property(x => x.Floor)
                .HasMaxLength(EntityConstants.MaxFloorLength);

            builder.Property(x => x.FloorsNumber)
               .HasMaxLength(EntityConstants.MaxFloorLength);


            builder.Property(x => x.RoomNumber)
               .HasMaxLength(EntityConstants.MaxFloorLength);


            builder.Property(x => x.ParkingType)
               .HasMaxLength(EntityConstants.MaxNameLength);

            builder.Property(x => x.BuildingType)
               .HasMaxLength(EntityConstants.MaxNameLength);

            builder.Property(x => x.AuthorType)
               .HasMaxLength(EntityConstants.MaxNameLength);

            builder.Property(x => x.LandType)
             .HasMaxLength(EntityConstants.MaxNameLength);
        }

    }
}
