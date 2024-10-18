using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierPricingDetailConfiguration : IEntityTypeConfiguration<SupplierPricingDetail>
{
    public void Configure(EntityTypeBuilder<SupplierPricingDetail> entity)
    {
        entity
                .HasNoKey()
                .ToTable("SupplierPricingDetail");

        entity.HasIndex(e => new { e.SupPriPricingGroupId, e.LowerQuantityLimit, e.HigherQuantityLimit, e.PricePerPiece }, "SupplierPricingDetail_IX1");

        entity.Property(e => e.PricePerPiece).HasColumnType("money");
        entity.Property(e => e.SupPriPricingGroupId).HasColumnName("SupPri__PricingGroupID");


        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierPricingDetail> entity);
}
