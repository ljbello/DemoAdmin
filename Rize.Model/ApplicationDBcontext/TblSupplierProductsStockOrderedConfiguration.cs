using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblSupplierProductsStockOrderedConfiguration : IEntityTypeConfiguration<TblSupplierProductsStockOrdered>
{
    public void Configure(EntityTypeBuilder<TblSupplierProductsStockOrdered> entity)
    {
        entity.HasKey(e => e.Rowguid);

        entity.ToTable("tblSupplierProductsStockOrdered");

        entity.HasIndex(e => e.SupProDateOrderEta, "tblSupplierProductsStockOrdered_IX1");

        entity.Property(e => e.Rowguid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("rowguid");
        entity.Property(e => e.ProSupplierProductNumber)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("Pro__SupplierProductNumber");
        entity.Property(e => e.SupProDateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("SupPro__DateCreated");
        entity.Property(e => e.SupProDateOrderEta)
                .HasColumnType("datetime")
                .HasColumnName("SupPro__DateOrderETA");
        entity.Property(e => e.SupProQuanityOnOrder).HasColumnName("SupPro__QuanityOnOrder");
        entity.Property(e => e.SupSupplierId).HasColumnName("Sup__SupplierID");

        entity.HasOne(d => d.SupSupplier).WithMany(p => p.TblSupplierProductsStockOrdereds)
                .HasForeignKey(d => d.SupSupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblSupplierProductsStockOrdered_tblSuppliers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblSupplierProductsStockOrdered> entity);
}
