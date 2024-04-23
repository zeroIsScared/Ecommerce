﻿

using Ecommerce.Domain.Entities;
using Ecommerce.Infrastracture.Constants;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastracture.EntityConfigurations
{
    internal class AddressConfiguration : BaseEntityConfiguration<Address>
    {
        public override void Configure(EntityTypeBuilder<Address> builder)
        {
            base.Configure(builder);
            builder.HasOne(s => s.Locality)
                  .WithMany(s => s.Properties)
                  .HasForeignKey(s => s.LocalityId);

            builder.Property(s => s.Street)
                .HasMaxLength(EntityConstants.MaxNameLength);


            builder.Property(s => s.HouseNumber)
                .HasMaxLength(EntityConstants.MaxHouseNumberLength);
        }
    }
}