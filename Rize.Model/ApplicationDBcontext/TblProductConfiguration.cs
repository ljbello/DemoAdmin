using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblProductConfiguration : IEntityTypeConfiguration<TblProduct>
{
    public void Configure(EntityTypeBuilder<TblProduct> entity)
    {
        entity.HasKey(e => e.ProProductId).HasName("tblProducts_PK");

        entity.ToTable("tblProducts");

        entity.HasIndex(e => new { e.SupSupplierId, e.ProProductId }, "_dta_index_tblProducts_7_809821997__K17_K3_K1");

        entity.HasIndex(e => e.ProProductId, "_dta_index_tblProducts_7_809821997__K1_K17");

        entity.HasIndex(e => e.ProProductNumber, "_dta_index_tblProducts_7_809821997__K2_1");

        entity.HasIndex(e => e.ProSupplierProductNumber, "index_124");

        entity.HasIndex(e => e.ProductTypeId, "index_127");

        entity.HasIndex(e => e.SupSupplierId, "index_8294");

        entity.HasIndex(e => new { e.SupSupplierId, e.ProductTypeId }, "index_8387");

        entity.HasIndex(e => new { e.ProProductId, e.SupSupplierId }, "ndx_tblProducts_Pro__ProductIDSup__SupplierID");

        entity.HasIndex(e => new { e.ProProductId, e.SupSupplierId }, "tblProducts_IX1");

        entity.HasIndex(e => e.ProPreviewVersion, "tblProducts_IX2");

        entity.HasIndex(e => e.SupSupplierId, "tblProducts_IX3");

        entity.HasIndex(e => e.ProductionTypeId, "tblProducts_IX4");

        entity.HasIndex(e => e.ProManufacturerProductNumber, "tblProducts_IX5");

        entity.HasIndex(e => e.ProManufacturerItemNumber, "tblProducts_IX6");

        entity.HasIndex(e => e.ProAdditionalKeywords, "tblProducts_IX7");

        entity.HasIndex(e => e.ProductTypeId, "tblProducts_IX8");

        entity.Property(e => e.ProProductId).HasColumnName("Pro__ProductID");
        entity.Property(e => e.AutoExclusive).HasDefaultValue(true);
        entity.Property(e => e.CategoryDisplayClass)
                .HasMaxLength(15)
                .IsUnicode(false);
        entity.Property(e => e.CollectionIdDefault).HasColumnName("CollectionId_Default");
        entity.Property(e => e.CustomColors)
                .HasMaxLength(250)
                .IsUnicode(false);
        entity.Property(e => e.EditorAnimationsOff).HasDefaultValue(false);
        entity.Property(e => e.EnvironmentImageCount).HasDefaultValue(0);
        entity.Property(e => e.ImageCount).HasDefaultValue(0);
        entity.Property(e => e.ManManufacturerId).HasColumnName("Man__ManufacturerID");
        entity.Property(e => e.OccasionIdDefault).HasColumnName("OccasionId_Default");
        entity.Property(e => e.ProAdditionalKeywords)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("Pro__AdditionalKeywords");
        entity.Property(e => e.ProCardsPerPack).HasColumnName("Pro__CardsPerPack");
        entity.Property(e => e.ProDateAdded)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Pro__DateAdded");
        entity.Property(e => e.ProInternalNotes)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("Pro__InternalNotes");
        entity.Property(e => e.ProLogoSet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Pro__LogoSet");
        entity.Property(e => e.ProManufacturerItemNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Pro__ManufacturerItemNumber");
        entity.Property(e => e.ProManufacturerProductNumber)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("Pro__ManufacturerProductNumber");
        entity.Property(e => e.ProPreviewVersion).HasColumnName("Pro__PreviewVersion");
        entity.Property(e => e.ProPrice)
                .HasColumnType("money")
                .HasColumnName("Pro__Price");
        entity.Property(e => e.ProProductNumber)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("Pro__ProductNumber");
        entity.Property(e => e.ProPunchoutProductNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Pro__PunchoutProductNumber");
        entity.Property(e => e.ProSampleOnOrderDate)
                .HasDefaultValueSql("((0))")
                .HasColumnType("smalldatetime")
                .HasColumnName("Pro__SampleOnOrder_Date");
        entity.Property(e => e.ProSampleSupplierId).HasColumnName("Pro__SampleSupplierID");
        entity.Property(e => e.ProSoldInPacks).HasColumnName("Pro__SoldInPacks");
        entity.Property(e => e.ProSupplierProductNumber)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("Pro__SupplierProductNumber");
        entity.Property(e => e.ProTimProductionTimeId).HasColumnName("ProTim__ProductionTimeID");
        entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");
        entity.Property(e => e.ProductUseId).HasColumnName("ProductUseID");
        entity.Property(e => e.ProductionTypeId).HasColumnName("ProductionTypeID");
        entity.Property(e => e.StyleIdDefault).HasColumnName("StyleId_Default");
        entity.Property(e => e.SupSupplierId).HasColumnName("Sup__SupplierID");
        entity.Property(e => e.ThemeIdDefault).HasColumnName("ThemeId_Default");
        entity.Property(e => e.UpdatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.VendorArtworkId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VendorArtworkID");
        entity.Property(e => e.VerseInkColor)
                .HasMaxLength(8)
                .IsUnicode(false);
        entity.Property(e => e.WeightPer25).HasColumnType("decimal(16, 2)");

        entity.HasOne(d => d.ManManufacturer).WithMany(p => p.TblProducts)
                .HasForeignKey(d => d.ManManufacturerId)
                .HasConstraintName("FK_tblProducts_tblManufacturers");

        entity.HasOne(d => d.ProSampleSupplier).WithMany(p => p.TblProductProSampleSuppliers)
                .HasForeignKey(d => d.ProSampleSupplierId)
                .HasConstraintName("FK_tblProducts_tblSuppliers1");

        entity.HasOne(d => d.ProTimProductionTime).WithMany(p => p.TblProducts)
                .HasForeignKey(d => d.ProTimProductionTimeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblProducts_tblProductionTimes");

        entity.HasOne(d => d.ProductType).WithMany(p => p.TblProducts)
                .HasForeignKey(d => d.ProductTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblProducts_ProductType");

        entity.HasOne(d => d.SupSupplier).WithMany(p => p.TblProductSupSuppliers)
                .HasForeignKey(d => d.SupSupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblProducts_tblSuppliers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblProduct> entity);
}
