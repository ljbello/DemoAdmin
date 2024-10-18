using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductVariationSectionLayoutConfiguration : IEntityTypeConfiguration<ProductVariationSectionLayout>
{
    public void Configure(EntityTypeBuilder<ProductVariationSectionLayout> entity)
    {
        entity.HasKey(e => new { e.ProductId, e.ProductVariationId, e.SectionId, e.LayoutId }).HasName("PK_Section_Layout");

        entity.ToTable("ProductVariation_Section_Layout");

        entity.HasIndex(e => e.LayoutId, "ProductVariation_Section_Layout_IX1");

        entity.HasOne(d => d.Layout).WithMany(p => p.ProductVariationSectionLayouts)
                .HasForeignKey(d => d.LayoutId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductVariation_Section_Layout_Layout");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductVariationSectionLayout> entity);
}
