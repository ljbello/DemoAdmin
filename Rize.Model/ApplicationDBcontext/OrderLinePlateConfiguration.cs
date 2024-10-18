using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OrderLinePlateConfiguration : IEntityTypeConfiguration<OrderLinePlate>
{
    public void Configure(EntityTypeBuilder<OrderLinePlate> entity)
    {
        entity.HasKey(e => e.OrderLinePlatesId);

        entity.HasIndex(e => new { e.OrderId, e.Created }, "OrderLinePlates_IX1");

        entity.HasIndex(e => new { e.OrderLineId, e.Locked }, "OrderLinePlates_IX2");

        entity.HasIndex(e => new { e.Created, e.PlateError }, "OrderLinePlates_IX4");

        entity.Property(e => e.CreatedDate).HasColumnType("datetime");
        entity.Property(e => e.MachineInstanceId)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Message).IsUnicode(false);
        entity.Property(e => e.OrderNumber)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.PlateErrorMessage).IsUnicode(false);
        entity.Property(e => e.PlateQueueOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.QueueBy).HasDefaultValue(1);

        entity.HasOne(d => d.Order).WithMany(p => p.OrderLinePlates)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderLinePlates_Order");

        entity.HasOne(d => d.OrderLine).WithMany(p => p.OrderLinePlates)
                .HasForeignKey(d => d.OrderLineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderLinePlates_tblOrderLines");

        entity.HasOne(d => d.QueueByNavigation).WithMany(p => p.OrderLinePlates)
                .HasForeignKey(d => d.QueueBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderLinePlates_QueueBy_tblUsers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<OrderLinePlate> entity);
}
