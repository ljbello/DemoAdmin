using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductVariationInkColorConfiguration : IEntityTypeConfiguration<ProductVariationInkColor>
{
    public void Configure(EntityTypeBuilder<ProductVariationInkColor> entity)
    {
        entity
                .HasNoKey()
                .ToTable("ProductVariation_InkColor");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductVariationInkColor> entity);
}
