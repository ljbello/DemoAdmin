using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductProductVariationConfiguration : IEntityTypeConfiguration<ProductProductVariation>
{
    public void Configure(EntityTypeBuilder<ProductProductVariation> entity)
    {
        entity.HasKey(e => new { e.ProductId, e.ProductVariationId, e.StoreId });

        entity.ToTable("Product_ProductVariation");

        entity.HasIndex(e => new { e.ProductVariationId, e.StoreId }, "Product_ProductVariation_IX2");

        entity.HasIndex(e => new { e.StoreId, e.ProductVariationId }, "Product_ProductVariation_IX3");

        entity.HasIndex(e => new { e.StoreId, e.IsActive }, "Product_ProductVariation_IX4");

        entity.HasIndex(e => new { e.ProductId, e.SupplierPricingGroupId }, "Product_productVariation_IX1");

        entity.HasIndex(e => e.SupplierPricingGroupId, "ndx_Product_ProductVariation_SupplierPricingGroupId");

        entity.Property(e => e.StoreId)
                .HasDefaultValue(1)
                .HasColumnName("StoreID");
        entity.Property(e => e.DividerImage).HasMaxLength(100);
        entity.Property(e => e.IsActive).HasDefaultValue(true);
        entity.Property(e => e.PaperStockImage).HasMaxLength(100);
        entity.Property(e => e.VendorArtworkId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VendorArtworkID");

        entity.HasOne(d => d.Product).WithMany(p => p.ProductProductVariations)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_ProductVariation_tblProducts");

        entity.HasOne(d => d.ProductVariation).WithMany(p => p.ProductProductVariations)
                .HasForeignKey(d => d.ProductVariationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_ProductVariation_ProductVariation");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductProductVariation> entity);
}
