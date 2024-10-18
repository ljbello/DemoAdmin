using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class GetStoreShippingGlobalRateConfiguration : IEntityTypeConfiguration<GetStoreShippingGlobalRate>
{
    public void Configure(EntityTypeBuilder<GetStoreShippingGlobalRate> entity)
    {
        entity
                .HasNoKey()
                .ToView("GetStoreShippingGlobalRates");

        entity.Property(e => e.ShippingMethodDescription)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.StoreName)
                .HasMaxLength(4)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<GetStoreShippingGlobalRate> entity);
}
