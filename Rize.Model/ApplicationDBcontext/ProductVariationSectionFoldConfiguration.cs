using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductVariationSectionFoldConfiguration : IEntityTypeConfiguration<ProductVariationSectionFold>
{
    public void Configure(EntityTypeBuilder<ProductVariationSectionFold> entity)
    {
        entity.ToTable("ProductVariation_Section_Fold");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.Orientation)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

        entity.HasOne(d => d.Variation).WithMany(p => p.ProductVariationSectionFolds)
                .HasForeignKey(d => d.VariationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductVariation_Section_Fold_ProductVariation");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductVariationSectionFold> entity);
}
