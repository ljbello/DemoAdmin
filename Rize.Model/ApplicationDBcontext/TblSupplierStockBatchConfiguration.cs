using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblSupplierStockBatchConfiguration : IEntityTypeConfiguration<TblSupplierStockBatch>
{
    public void Configure(EntityTypeBuilder<TblSupplierStockBatch> entity)
    {
        entity.HasKey(e => e.Rowguid).HasName("PK_tblSupplierStockRequests_1");

        entity.ToTable("tblSupplierStockBatches");

        entity.Property(e => e.Rowguid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("rowguid");
        entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.ExceptionMessage).IsUnicode(false);
        entity.Property(e => e.ExceptionType)
                .HasMaxLength(128)
                .IsUnicode(false);
        entity.Property(e => e.RequestedBy)
                .HasMaxLength(3)
                .IsUnicode(false);
        entity.Property(e => e.SupSupplierId).HasColumnName("Sup__SupplierID");
        entity.Property(e => e.XmlRequestStock).HasColumnType("xml");
        entity.Property(e => e.XmlResponseStock).HasColumnType("xml");

        entity.HasOne(d => d.SupSupplier).WithMany(p => p.TblSupplierStockBatches)
                .HasForeignKey(d => d.SupSupplierId)
                .HasConstraintName("FK_tblSupplierStockRequests_tblSuppliers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblSupplierStockBatch> entity);
}
