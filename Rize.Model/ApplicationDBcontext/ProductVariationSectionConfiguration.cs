using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductVariationSectionConfiguration : IEntityTypeConfiguration<ProductVariationSection>
{
    public void Configure(EntityTypeBuilder<ProductVariationSection> entity)
    {
        entity.HasKey(e => new { e.ProductId, e.ProductVariationId, e.SectionId }).HasName("PK_Product_Section");

        entity.ToTable("ProductVariation_Section");

        entity.HasIndex(e => e.ProductVariationId, "ProductVariation_Section_IX1");

        entity.Property(e => e.PlateAnchor).HasDefaultValue(1);
        entity.Property(e => e.PreviewGroup)
                .HasMaxLength(30)
                .IsUnicode(false);
        entity.Property(e => e.Shadow).HasDefaultValue(true);

        entity.HasOne(d => d.ProductVariation).WithMany(p => p.ProductVariationSections)
                .HasForeignKey(d => d.ProductVariationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductVariation_Section_ProductVariation");

        entity.HasOne(d => d.Section).WithMany(p => p.ProductVariationSections)
                .HasForeignKey(d => d.SectionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_Section_Section");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductVariationSection> entity);
}
