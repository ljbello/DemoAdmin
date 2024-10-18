using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TestBaseProductPricingInfoConfiguration : IEntityTypeConfiguration<TestBaseProductPricingInfo>
{
    public void Configure(EntityTypeBuilder<TestBaseProductPricingInfo> entity)
    {
        entity
                .HasNoKey()
                .ToView("TestBaseProductPricingInfo");

        entity.Property(e => e.StoStoreId).HasColumnName("Sto__StoreID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TestBaseProductPricingInfo> entity);
}
