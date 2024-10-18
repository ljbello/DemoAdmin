using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VariationPricingGroupDefaultConfiguration : IEntityTypeConfiguration<VariationPricingGroupDefault>
{
    public void Configure(EntityTypeBuilder<VariationPricingGroupDefault> entity)
    {
        entity.HasKey(e => new { e.PricingGroupId, e.VariationId, e.ProductTypeId });

        entity.ToTable("VariationPricingGroupDefault");

        entity.HasIndex(e => new { e.VariationId, e.ProductTypeId, e.PricingGroupId, e.CreatedOn, e.StoreId }, "VariationPricingGroupDefault_IX1");

        entity.Property(e => e.PricingGroupId).HasColumnName("PricingGroupID");
        entity.Property(e => e.VariationId).HasColumnName("VariationID");
        entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.IsDefault).HasDefaultValue(true);
        entity.Property(e => e.StoreId).HasDefaultValue(1);

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.VariationPricingGroupDefaults)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VariationPricingGroupDefault_tblUsers");

        entity.HasOne(d => d.ProductType).WithMany(p => p.VariationPricingGroupDefaults)
                .HasForeignKey(d => d.ProductTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VariationPricingGroupDefault_ProductType");

        entity.HasOne(d => d.Store).WithMany(p => p.VariationPricingGroupDefaults)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VariationPricingGroupDefault_tblStores");

        entity.HasOne(d => d.Variation).WithMany(p => p.VariationPricingGroupDefaults)
                .HasForeignKey(d => d.VariationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VariationPricingGroupDefault_ProductVariation");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VariationPricingGroupDefault> entity);
}
