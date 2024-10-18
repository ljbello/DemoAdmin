using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductVariationSectionTemplateConfiguration : IEntityTypeConfiguration<ProductVariationSectionTemplate>
{
    public void Configure(EntityTypeBuilder<ProductVariationSectionTemplate> entity)
    {
        entity.HasKey(e => new { e.ProductVariationId, e.SectionId });

        entity.ToTable("ProductVariation_Section_Template");

        entity.Property(e => e.PlateAnchor).HasDefaultValue(1);
        entity.Property(e => e.PreviewGroup)
                .HasMaxLength(30)
                .IsUnicode(false);
        entity.Property(e => e.Shadow).HasDefaultValue(true);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductVariationSectionTemplate> entity);
}
