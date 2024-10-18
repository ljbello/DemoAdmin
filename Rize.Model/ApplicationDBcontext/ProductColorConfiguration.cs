using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductColorConfiguration : IEntityTypeConfiguration<ProductColor>
{
    public void Configure(EntityTypeBuilder<ProductColor> entity)
    {
        entity.ToTable("ProductColor");

        entity.HasIndex(e => e.ProductId, "ProductColor_IX1");

        entity.HasIndex(e => new { e.Percentage, e.ColorName }, "ProductColor_IX2");

        entity.Property(e => e.ColorName)
                .HasMaxLength(20)
                .IsUnicode(false);
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.HexCode)
                .HasMaxLength(7)
                .IsUnicode(false);
        entity.Property(e => e.Percentage).HasColumnType("decimal(5, 2)");

        entity.HasOne(d => d.Product).WithMany(p => p.ProductColors)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductColor_tblProducts");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductColor> entity);
}
