using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class CdcardImportConfiguration : IEntityTypeConfiguration<CdcardImport>
{
    public void Configure(EntityTypeBuilder<CdcardImport> entity)
    {
        entity
                .HasNoKey()
                .ToTable("CDCardImport");

        entity.Property(e => e.Album).HasMaxLength(255);
        entity.Property(e => e.Category)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.DateStockExpected).HasColumnType("datetime");
        entity.Property(e => e.DefaultVerse)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.Description).HasMaxLength(255);
        entity.Property(e => e.DiscountPricingGroupId).HasColumnName("DiscountPricingGroupID");
        entity.Property(e => e.Env)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.EnvelopeDescription)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.FastickEnvelopes)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.I123PrintThemeId).HasColumnName("i123PrintThemeId");
        entity.Property(e => e.I123PrintTypeId).HasColumnName("i123PrintTypeId");
        entity.Property(e => e.IId)
                .ValueGeneratedOnAdd()
                .HasColumnName("iID");
        entity.Property(e => e.IMatchingManManufacturerId).HasColumnName("iMatching_Man__ManufacturerID");
        entity.Property(e => e.IMatchingSupPriPricingGroupId).HasColumnName("iMatching_SupPri__PricingGroupID");
        entity.Property(e => e.ImageBaseName)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.Ink).HasMaxLength(255);
        entity.Property(e => e.ManufacturerCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.MasterListNumber).HasMaxLength(255);
        entity.Property(e => e.Orientation)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.PageNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.PhotoOrDesign)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.PreversedOrBlank).HasMaxLength(255);
        entity.Property(e => e.PricePoint)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ProductName)
                .HasMaxLength(256)
                .IsUnicode(false);
        entity.Property(e => e.PureCardNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.RepeatOrNew)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.SellingPriceGroupId).HasColumnName("SellingPriceGroupID");
        entity.Property(e => e.Size)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.StoreId).HasColumnName("StoreID");
        entity.Property(e => e.SupplierPriceGroupId).HasColumnName("SupplierPriceGroupID");
        entity.Property(e => e.VerseGroup)
                .HasMaxLength(100)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<CdcardImport> entity);
}
