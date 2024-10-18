using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VProductConfigurationConfiguration : IEntityTypeConfiguration<VProductConfiguration>
{
    public void Configure(EntityTypeBuilder<VProductConfiguration> entity)
    {
        entity
                .HasNoKey()
                .ToView("vProductConfiguration");

        entity.Property(e => e.ActiveDate).HasColumnType("datetime");
        entity.Property(e => e.AreaMode).HasMaxLength(50);
        entity.Property(e => e.DiscountGroupId).HasColumnName("DiscountGroupID");
        entity.Property(e => e.ManManufacturerId).HasColumnName("Man__ManufacturerID");
        entity.Property(e => e.PlateImage).HasMaxLength(255);
        entity.Property(e => e.PlateType)
                .HasMaxLength(10)
                .IsUnicode(false);
        entity.Property(e => e.PreviewGroup)
                .HasMaxLength(30)
                .IsUnicode(false);
        entity.Property(e => e.PreviewImage).HasMaxLength(255);
        entity.Property(e => e.ProDateAdded)
                .HasColumnType("datetime")
                .HasColumnName("Pro__DateAdded");
        entity.Property(e => e.ProDescription)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("Pro__Description");
        entity.Property(e => e.ProManufacturerProductNumber)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("Pro__ManufacturerProductNumber");
        entity.Property(e => e.ProStaProductStatusId).HasColumnName("ProSta__ProductStatusID");
        entity.Property(e => e.ProductNumber)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");
        entity.Property(e => e.ProductionTypeId).HasColumnName("ProductionTypeID");
        entity.Property(e => e.ShortName)
                .HasMaxLength(20)
                .IsUnicode(false);
        entity.Property(e => e.SupSupplierId).HasColumnName("Sup__SupplierID");
        entity.Property(e => e.VariationName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.X).HasColumnName("x");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VProductConfiguration> entity);
}
