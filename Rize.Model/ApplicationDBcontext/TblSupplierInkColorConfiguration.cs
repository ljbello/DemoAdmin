using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblSupplierInkColorConfiguration : IEntityTypeConfiguration<TblSupplierInkColor>
{
    public void Configure(EntityTypeBuilder<TblSupplierInkColor> entity)
    {
        entity.HasKey(e => new { e.InkColInkColorId, e.SupSupplierId }).HasName("tblSupplierInkColors_PK");

        entity.ToTable("tblSupplierInkColors");

        entity.Property(e => e.InkColInkColorId).HasColumnName("InkCol__InkColorID");
        entity.Property(e => e.SupSupplierId).HasColumnName("Sup__SupplierID");
        entity.Property(e => e.SupInkColCode)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("SupInkCol__Code");

        entity.HasOne(d => d.InkColInkColor).WithMany(p => p.TblSupplierInkColors)
                .HasForeignKey(d => d.InkColInkColorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tblInkColors_tblSupplierInkColors_FK1");

        entity.HasOne(d => d.SupSupplier).WithMany(p => p.TblSupplierInkColors)
                .HasForeignKey(d => d.SupSupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tblSuppliers_tblSupplierInkColors_FK1");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblSupplierInkColor> entity);
}
