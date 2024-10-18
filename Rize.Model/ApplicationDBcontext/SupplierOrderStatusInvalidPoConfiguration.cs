using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierOrderStatusInvalidPoConfiguration : IEntityTypeConfiguration<SupplierOrderStatusInvalidPo>
{
    public void Configure(EntityTypeBuilder<SupplierOrderStatusInvalidPo> entity)
    {
        entity.ToTable("SupplierOrderStatusInvalidPO");

        entity.HasIndex(e => new { e.SupplierOrderNumber, e.SupplierId }, "IX_SupplierOrderStatusInvalidPO").IsUnique();

        entity.Property(e => e.SupplierOrderStatusInvalidPoId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("SupplierOrderStatusInvalidPoID");
        entity.Property(e => e.CreationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Discrepancy).IsUnicode(false);
        entity.Property(e => e.OrderNumber)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.OrderStatusId).HasColumnName("OrderStatusID");
        entity.Property(e => e.RunDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.ShippingCarrierId).HasColumnName("ShippingCarrierID");
        entity.Property(e => e.ShippingMethodId).HasColumnName("ShippingMethodID");
        entity.Property(e => e.StatusDate).HasColumnType("datetime");
        entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
        entity.Property(e => e.SupplierOrderNumber)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.TrackingNumber)
                .HasMaxLength(255)
                .IsUnicode(false);

        entity.HasOne(d => d.OrderStatus).WithMany(p => p.SupplierOrderStatusInvalidPos)
                .HasForeignKey(d => d.OrderStatusId)
                .HasConstraintName("FK_SupplierOrderStatusInvalidPO_tblOrderStatuses");

        entity.HasOne(d => d.Supplier).WithMany(p => p.SupplierOrderStatusInvalidPos)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierOrderStatusInvalidPO_tblSuppliers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierOrderStatusInvalidPo> entity);
}
