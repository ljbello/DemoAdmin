using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblOrderLineStatusConfiguration : IEntityTypeConfiguration<TblOrderLineStatus>
{
    public void Configure(EntityTypeBuilder<TblOrderLineStatus> entity)
    {
        entity.HasKey(e => e.OrderLineStatusId).HasName("PK_tblOrderLineStatus_1");

        entity.ToTable("tblOrderLineStatus");

        entity.HasIndex(e => new { e.OrderStatusId, e.OrderLineId }, "IX_tblOrderLineStatus")
                .IsUnique()
                .HasFillFactor(100);

        entity.HasIndex(e => new { e.OrderStatusId, e.OrderLineId, e.WorkFlowId }, "IX_tblOrderLineStatusOrderLine").IsUnique();

        entity.HasIndex(e => new { e.OrderLineId, e.WorkFlowId }, "IX_tblOrderLineWorkFlowOrderline").IsUnique();

        entity.Property(e => e.OrderLineStatusId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("OrderLineStatusID");
        entity.Property(e => e.CreationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
        entity.Property(e => e.Notes).IsUnicode(false);
        entity.Property(e => e.OrderLineId).HasColumnName("OrderLineID");
        entity.Property(e => e.OrderNumber)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.OrderStatusId).HasColumnName("OrderStatusID");
        entity.Property(e => e.RunDate).HasColumnType("datetime");
        entity.Property(e => e.ShippingCarrierId).HasColumnName("ShippingCarrierID");
        entity.Property(e => e.ShippingDate).HasColumnType("datetime");
        entity.Property(e => e.ShippingMethodId).HasColumnName("ShippingMethodID");
        entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
        entity.Property(e => e.TrackingNumber)
                .HasMaxLength(3000)
                .IsUnicode(false);

        entity.HasOne(d => d.OrderLine).WithMany(p => p.TblOrderLineStatuses)
                .HasForeignKey(d => d.OrderLineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblOrderLineStatus_tblOrderLines");

        entity.HasOne(d => d.OrderStatus).WithMany(p => p.TblOrderLineStatuses)
                .HasForeignKey(d => d.OrderStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblOrderLineStatus_tblOrderStatuses");

        entity.HasOne(d => d.ShippingMethod).WithMany(p => p.TblOrderLineStatuses)
                .HasForeignKey(d => d.ShippingMethodId)
                .HasConstraintName("FK_tblOrderLineStatus_tblShippingMethods");

        entity.HasOne(d => d.Supplier).WithMany(p => p.TblOrderLineStatuses)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblOrderLineStatus_tblSuppliers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblOrderLineStatus> entity);
}
