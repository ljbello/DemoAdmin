using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductThemeConfiguration : IEntityTypeConfiguration<ProductTheme>
{
    public void Configure(EntityTypeBuilder<ProductTheme> entity)
    {
        entity.ToTable("ProductTheme");

        entity.HasIndex(e => new { e.ThemeId, e.ProductId }, "ProductTheme_IX1").IsUnique();

        entity.HasIndex(e => e.ProductId, "ProductTheme_IX2");

        entity.Property(e => e.ProductThemeId).HasColumnName("ProductThemeID");
        entity.Property(e => e.Active).HasDefaultValue(true);
        entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.ParentThemeId).HasColumnName("ParentThemeID");
        entity.Property(e => e.ProductId).HasColumnName("ProductID");
        entity.Property(e => e.ThemeId).HasColumnName("ThemeID");

        entity.HasOne(d => d.Product).WithMany(p => p.ProductThemes)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductTheme_tblProducts");

        entity.HasOne(d => d.Theme).WithMany(p => p.ProductThemes)
                .HasForeignKey(d => d.ThemeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductTheme_Theme");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductTheme> entity);
}
