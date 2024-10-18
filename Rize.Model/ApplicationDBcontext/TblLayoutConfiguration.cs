using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblLayoutConfiguration : IEntityTypeConfiguration<TblLayout>
{
    public void Configure(EntityTypeBuilder<TblLayout> entity)
    {
        entity.HasKey(e => e.LayLayoutId).HasName("PK_Layouts");

        entity.ToTable("tblLayouts");

        entity.HasIndex(e => new { e.ManManufacturerId, e.LayManufacturerItemNumber }, "tblLayouts_IX1");

        entity.Property(e => e.LayLayoutId).HasColumnName("Lay__LayoutID");
        entity.Property(e => e.LayHeight).HasColumnName("Lay__Height");
        entity.Property(e => e.LayManufacturerItemNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Lay__ManufacturerItemNumber");
        entity.Property(e => e.LayPriority).HasColumnName("Lay__Priority");
        entity.Property(e => e.LayTypLayoutTypeId).HasColumnName("LayTyp__LayoutTypeID");
        entity.Property(e => e.LayWidth).HasColumnName("Lay__Width");
        entity.Property(e => e.ManManufacturerId).HasColumnName("Man__ManufacturerID");
        entity.Property(e => e.SupSupplierId).HasColumnName("Sup__SupplierID");

        entity.HasOne(d => d.LayTypLayoutType).WithMany(p => p.TblLayouts)
                .HasForeignKey(d => d.LayTypLayoutTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblLayouts_tblLayoutTypes");

        entity.HasOne(d => d.ManManufacturer).WithMany(p => p.TblLayouts)
                .HasForeignKey(d => d.ManManufacturerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblLayouts_tblManufacturers");

        entity.HasOne(d => d.SupSupplier).WithMany(p => p.TblLayouts)
                .HasForeignKey(d => d.SupSupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblLayouts_tblSuppliers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblLayout> entity);
}
