using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductVariationSectionPlateConfiguration : IEntityTypeConfiguration<ProductVariationSectionPlate>
{
    public void Configure(EntityTypeBuilder<ProductVariationSectionPlate> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK_ProductVairation_SectionPlate");

        entity.ToTable("ProductVariation_SectionPlate");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.Color)
                .HasMaxLength(20)
                .IsUnicode(false);
        entity.Property(e => e.FileName).HasMaxLength(255);

        entity.HasOne(d => d.Product).WithMany(p => p.ProductVariationSectionPlates)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductVairation_SectionPlate_tblProducts");

        entity.HasOne(d => d.Variation).WithMany(p => p.ProductVariationSectionPlates)
                .HasForeignKey(d => d.VariationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductVairation_SectionPlate_ProductVariation");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductVariationSectionPlate> entity);
}
