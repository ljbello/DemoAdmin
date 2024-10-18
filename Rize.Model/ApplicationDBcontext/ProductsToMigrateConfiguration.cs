using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductsToMigrateConfiguration : IEntityTypeConfiguration<ProductsToMigrate>
{
    public void Configure(EntityTypeBuilder<ProductsToMigrate> entity)
    {
        entity
                .HasNoKey()
                .ToTable("ProductsToMigrate");

        entity.Property(e => e.BackImage).HasMaxLength(255);
        entity.Property(e => e.CardOrientation)
                .HasMaxLength(4)
                .IsUnicode(false);
        entity.Property(e => e.DefaultFont)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.DefaultFontColor)
                .HasMaxLength(20)
                .IsUnicode(false);
        entity.Property(e => e.Dimensions)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ErrorMessage).HasMaxLength(255);
        entity.Property(e => e.FrontImage).HasMaxLength(255);
        entity.Property(e => e.InkColorName)
                .HasMaxLength(20)
                .IsUnicode(false);
        entity.Property(e => e.Inside1Image).HasMaxLength(255);
        entity.Property(e => e.Inside2Image).HasMaxLength(255);
        entity.Property(e => e.ManId).HasColumnName("ManID");
        entity.Property(e => e.ManItemNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ManProductNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ProductNumber)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.SupplierEnvelopeCode)
                .HasMaxLength(16)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductsToMigrate> entity);
}
