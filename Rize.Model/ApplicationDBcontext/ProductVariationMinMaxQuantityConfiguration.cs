using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductVariationMinMaxQuantityConfiguration : IEntityTypeConfiguration<ProductVariationMinMaxQuantity>
{
    public void Configure(EntityTypeBuilder<ProductVariationMinMaxQuantity> entity)
    {
        entity.ToTable("ProductVariation_MinMaxQuantity");

        entity.HasIndex(e => new { e.VariationId, e.StoreId, e.ProductTypeId }, "IX_ProductVariation_MinMaxQuantity").IsUnique();

        entity.Property(e => e.ProductTypeId).HasDefaultValue(1);

        entity.HasOne(d => d.Store).WithMany(p => p.ProductVariationMinMaxQuantities)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductVariation_MinMaxQuantity_tblStore");

        entity.HasOne(d => d.Variation).WithMany(p => p.ProductVariationMinMaxQuantities)
                .HasForeignKey(d => d.VariationId)
                .HasConstraintName("FK_ProductVariation_MinMaxQuantity_ProductVariation");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductVariationMinMaxQuantity> entity);
}
