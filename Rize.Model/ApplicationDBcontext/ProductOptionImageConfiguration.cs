using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductOptionImageConfiguration : IEntityTypeConfiguration<ProductOptionImage>
{
    public void Configure(EntityTypeBuilder<ProductOptionImage> entity)
    {
        entity.ToTable("ProductOptionImage");

        entity.HasIndex(e => new { e.ProductId, e.OptionKey }, "IX_ProductOptionImage").IsUnique();

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.OptionKey).HasMaxLength(50);

        entity.HasOne(d => d.Product).WithMany(p => p.ProductOptionImages)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductOptionImage_tblProducts");

        entity.HasOne(d => d.ProductImage).WithMany(p => p.ProductOptionImages)
                .HasForeignKey(d => d.ProductImageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductOptionImage_ProductImage");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductOptionImage> entity);
}
