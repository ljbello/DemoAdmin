using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VariationSizeMappingConfiguration : IEntityTypeConfiguration<VariationSizeMapping>
{
    public void Configure(EntityTypeBuilder<VariationSizeMapping> entity)
    {
        entity.ToTable("VariationSizeMapping");

        entity.HasOne(d => d.Size).WithMany(p => p.VariationSizeMappings)
                .HasForeignKey(d => d.SizeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VariationSizeMapping_tblSizes");

        entity.HasOne(d => d.Variation).WithMany(p => p.VariationSizeMappings)
                .HasForeignKey(d => d.VariationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VariationSizeMapping_ProductVariation");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VariationSizeMapping> entity);
}
