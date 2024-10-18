using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductImageConfiguration : IEntityTypeConfiguration<ProductImage>
{
    public void Configure(EntityTypeBuilder<ProductImage> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__ProductI__3214EC07B7478075");

        entity.ToTable("ProductImage");

        entity.HasIndex(e => e.ProductId, "ProductImage_IX1");

        entity.HasIndex(e => new { e.IsVisible, e.ProductId }, "ProductImage_IX2");

        entity.HasIndex(e => new { e.ImageTypeId, e.IsVisible, e.ProductId, e.SortIndex }, "ProductImage_IX3");

        entity.Property(e => e.AltTitle).HasMaxLength(255);
        entity.Property(e => e.ImageName).HasMaxLength(255);
        entity.Property(e => e.IsVisible).HasDefaultValue(true);
        entity.Property(e => e.ModifiedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

        entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.ProductImages)
                .HasForeignKey(d => d.ModifiedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductImage_tblUsers");

        entity.HasOne(d => d.Product).WithMany(p => p.ProductImages)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductImage_tblProducts");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductImage> entity);
}
