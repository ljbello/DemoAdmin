using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OrderNotificationConfiguration : IEntityTypeConfiguration<OrderNotification>
{
    public void Configure(EntityTypeBuilder<OrderNotification> entity)
    {
        entity.ToTable("OrderNotification");

        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.Message).HasMaxLength(800);

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.OrderNotifications)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderNotification_tblUsers");

        entity.HasOne(d => d.Order).WithMany(p => p.OrderNotifications)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK_OrderNotification_Order");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<OrderNotification> entity);
}
