using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class BaseProductPricingInfoConfiguration : IEntityTypeConfiguration<BaseProductPricingInfo>
{
    public void Configure(EntityTypeBuilder<BaseProductPricingInfo> entity)
    {
        entity
                .HasNoKey()
                .ToView("BaseProductPricingInfo");

        entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");
        entity.Property(e => e.StoStoreId).HasColumnName("Sto__StoreID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<BaseProductPricingInfo> entity);
}
