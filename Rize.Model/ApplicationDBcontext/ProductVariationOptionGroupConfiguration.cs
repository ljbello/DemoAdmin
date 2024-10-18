using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductVariationOptionGroupConfiguration : IEntityTypeConfiguration<ProductVariationOptionGroup>
{
    public void Configure(EntityTypeBuilder<ProductVariationOptionGroup> entity)
    {
        entity.ToTable("ProductVariation_OptionGroup");

        entity.HasIndex(e => new { e.StoreId, e.ProductVariationId, e.ProductOptionPriceGroupId }, "IX_ProductVariation_OptionGroup_StoreId_ProductVariationId").IsUnique();

        entity.Property(e => e.FriendlyName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ProductOptionPriceGroupId)
                .HasMaxLength(50)
                .IsUnicode(false);

        entity.HasOne(d => d.ProductVariation).WithMany(p => p.ProductVariationOptionGroups)
                .HasForeignKey(d => d.ProductVariationId)
                .HasConstraintName("FK_ProductVariation_OptionGroup_ProductVariation");

        entity.HasOne(d => d.Store).WithMany(p => p.ProductVariationOptionGroups)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK_ProductVariation_OptionGroup_tblStores");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductVariationOptionGroup> entity);
}
