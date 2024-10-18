using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductStyleConfiguration : IEntityTypeConfiguration<ProductStyle>
{
    public void Configure(EntityTypeBuilder<ProductStyle> entity)
    {
        entity.ToTable("ProductStyle");

        entity.HasIndex(e => new { e.ProductId, e.StyleId }, "ProductStyle_IX1").IsUnique();

        entity.HasIndex(e => e.StyleId, "ProductStyle_IX2");

        entity.Property(e => e.ProductStyleId).HasColumnName("ProductStyleID");
        entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.ProductId).HasColumnName("ProductID");
        entity.Property(e => e.StyleId).HasColumnName("StyleID");

        entity.HasOne(d => d.Product).WithMany(p => p.ProductStyles)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductStyle_tblProducts");

        entity.HasOne(d => d.Style).WithMany(p => p.ProductStyles)
                .HasForeignKey(d => d.StyleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductStyle_Style");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductStyle> entity);
}
