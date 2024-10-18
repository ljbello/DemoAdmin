using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class BaseProductPricingGroupConfiguration : IEntityTypeConfiguration<BaseProductPricingGroup>
{
    public void Configure(EntityTypeBuilder<BaseProductPricingGroup> entity)
    {
        entity
                .HasNoKey()
                .ToView("BaseProductPricingGroup");

        entity.Property(e => e.StoStoreId).HasColumnName("Sto__StoreID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<BaseProductPricingGroup> entity);
}
