using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ValidatedAddressConfiguration : IEntityTypeConfiguration<ValidatedAddress>
{
    public void Configure(EntityTypeBuilder<ValidatedAddress> entity)
    {
        entity.HasIndex(e => e.CustomerAddressId, "IDX_ValidatedAddreses_CustomerAddressId");

        entity.Property(e => e.AddressLine1).HasMaxLength(50);
        entity.Property(e => e.AddressLine2).HasMaxLength(50);
        entity.Property(e => e.City).HasMaxLength(50);
        entity.Property(e => e.NoSuggestions).HasDefaultValue(true);
        entity.Property(e => e.State).HasMaxLength(50);
        entity.Property(e => e.Zip).HasMaxLength(50);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ValidatedAddress> entity);
}
