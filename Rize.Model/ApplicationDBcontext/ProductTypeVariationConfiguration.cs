using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductTypeVariationConfiguration : IEntityTypeConfiguration<ProductTypeVariation>
{
    public void Configure(EntityTypeBuilder<ProductTypeVariation> entity)
    {
        entity.ToTable("ProductTypeVariation");

        entity.HasIndex(e => new { e.ProductTypeId, e.ProductVariationId }, "ProductTypeVariation_IX1").IsUnique();

        entity.HasOne(d => d.ProductType).WithMany(p => p.ProductTypeVariations)
                .HasForeignKey(d => d.ProductTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductTypeVariation_ProductType");

        entity.HasOne(d => d.ProductVariation).WithMany(p => p.ProductTypeVariations)
                .HasForeignKey(d => d.ProductVariationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductTypeVariation_ProductVariation");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductTypeVariation> entity);
}
