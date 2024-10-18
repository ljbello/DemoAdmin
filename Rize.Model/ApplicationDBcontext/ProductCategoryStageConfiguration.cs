using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductCategoryStageConfiguration : IEntityTypeConfiguration<ProductCategoryStage>
{
    public void Configure(EntityTypeBuilder<ProductCategoryStage> entity)
    {
        entity
                .HasNoKey()
                .ToTable("ProductCategoryStage");

        entity.Property(e => e.ArtSource).HasMaxLength(50);
        entity.Property(e => e.Collections).IsUnicode(false);
        entity.Property(e => e.DateActive).HasColumnType("datetime");
        entity.Property(e => e.DateCreated).HasColumnType("datetime");
        entity.Property(e => e.DefaultOccasionId).HasColumnName("DefaultOccasionID");
        entity.Property(e => e.DefaultThemeId).HasColumnName("DefaultThemeID");
        entity.Property(e => e.Department)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.Description)
                .HasMaxLength(2048)
                .IsUnicode(false);
        entity.Property(e => e.Designer).HasMaxLength(50);
        entity.Property(e => e.ImageName)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.Name)
                .HasMaxLength(256)
                .IsUnicode(false);
        entity.Property(e => e.Occasion)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Occasions).IsUnicode(false);
        entity.Property(e => e.ParentDepartment)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.PriceGroup)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.ProdId).HasColumnName("ProdID");
        entity.Property(e => e.ProductNumber)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.ProductType)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");
        entity.Property(e => e.ProductUseId).HasColumnName("ProductUseID");
        entity.Property(e => e.ProductionTypeId).HasColumnName("ProductionTypeID");
        entity.Property(e => e.Pvversion).HasColumnName("PVVersion");
        entity.Property(e => e.ReviewStars).HasColumnType("decimal(18, 2)");
        entity.Property(e => e.Status)
                .HasMaxLength(64)
                .IsUnicode(false);
        entity.Property(e => e.StoreId).HasColumnName("StoreID");
        entity.Property(e => e.Styles).IsUnicode(false);
        entity.Property(e => e.Supplier)
                .HasMaxLength(8000)
                .IsUnicode(false);
        entity.Property(e => e.SupplierSku)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("SupplierSKU");
        entity.Property(e => e.Theme)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Themes).IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductCategoryStage> entity);
}
