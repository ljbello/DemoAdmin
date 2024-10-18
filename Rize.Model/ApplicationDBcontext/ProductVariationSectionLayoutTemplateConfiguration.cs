using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductVariationSectionLayoutTemplateConfiguration : IEntityTypeConfiguration<ProductVariationSectionLayoutTemplate>
{
    public void Configure(EntityTypeBuilder<ProductVariationSectionLayoutTemplate> entity)
    {
        entity.HasKey(e => new { e.ProductVariationId, e.SectionId, e.LayoutId });

        entity.ToTable("ProductVariation_Section_Layout_Template");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductVariationSectionLayoutTemplate> entity);
}
