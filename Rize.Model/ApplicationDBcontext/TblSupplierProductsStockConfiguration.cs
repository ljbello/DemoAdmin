using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblSupplierProductsStockConfiguration : IEntityTypeConfiguration<TblSupplierProductsStock>
{
    public void Configure(EntityTypeBuilder<TblSupplierProductsStock> entity)
    {
        entity.HasKey(e => e.Rowguid);

        entity.ToTable("tblSupplierProductsStock");

        entity.HasIndex(e => new { e.ProSupplierProductNumber, e.SupSupplierId }, "IX_tblSupplierProductsStock_IX3");

        entity.HasIndex(e => e.SupProDateCreated, "tblSupplierProductsStock_IX1");

        entity.HasIndex(e => e.SupSupplierId, "tblSupplierProductsStock_IX2");

        entity.Property(e => e.Rowguid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("rowguid");
        entity.Property(e => e.ProSupplierProductNumber)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("Pro__SupplierProductNumber");
        entity.Property(e => e.SupProDateCreated)
                .HasColumnType("datetime")
                .HasColumnName("SupPro__DateCreated");
        entity.Property(e => e.SupProQuanityCommitted).HasColumnName("SupPro__QuanityCommitted");
        entity.Property(e => e.SupProQuanityOnHand).HasColumnName("SupPro__QuanityOnHand");
        entity.Property(e => e.SupProRequestedBy)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("SupPro__RequestedBy");
        entity.Property(e => e.SupProStockNumber)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("SupPro__StockNumber");
        entity.Property(e => e.SupSupplierId).HasColumnName("Sup__SupplierID");

        entity.HasOne(d => d.SupSupplier).WithMany(p => p.TblSupplierProductsStocks)
                .HasForeignKey(d => d.SupSupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblSupplierProducts_tblSuppliers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblSupplierProductsStock> entity);
}
