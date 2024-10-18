using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductProductVariationSupplierEnvelopeConfiguration : IEntityTypeConfiguration<ProductProductVariationSupplierEnvelope>
{
    public void Configure(EntityTypeBuilder<ProductProductVariationSupplierEnvelope> entity)
    {
        entity.HasKey(e => new { e.ProductId, e.ProductVariationId, e.SupplierEnvelopeId, e.StoreId });

        entity.ToTable("Product_ProductVariation_SupplierEnvelope");

        entity.HasIndex(e => e.SupplierEnvelopeId, "Product_ProductVariation_SupplierEnvelope_IX1");

        entity.HasIndex(e => e.ProductVariationId, "Product_ProductVariation_SupplierEnvelope_IX2");

        entity.Property(e => e.ProductId).HasColumnName("ProductID");
        entity.Property(e => e.ProductVariationId).HasColumnName("ProductVariationID");
        entity.Property(e => e.SupplierEnvelopeId).HasColumnName("SupplierEnvelopeID");
        entity.Property(e => e.StoreId).HasColumnName("StoreID");

        entity.HasOne(d => d.Product).WithMany(p => p.ProductProductVariationSupplierEnvelopes)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_ProductVariation_SupplierEnvelope_tblProducts");

        entity.HasOne(d => d.ProductVariation).WithMany(p => p.ProductProductVariationSupplierEnvelopes)
                .HasForeignKey(d => d.ProductVariationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_ProductVariation_SupplierEnvelope_ProductVariation");

        entity.HasOne(d => d.Store).WithMany(p => p.ProductProductVariationSupplierEnvelopes)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_ProductVariation_SupplierEnvelope_tblStores");

        entity.HasOne(d => d.SupplierEnvelope).WithMany(p => p.ProductProductVariationSupplierEnvelopes)
                .HasForeignKey(d => d.SupplierEnvelopeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_ProductVariation_SupplierEnvelope_tblSupplierEnvelopes");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductProductVariationSupplierEnvelope> entity);
}
