using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OrderNotificationUserConfiguration : IEntityTypeConfiguration<OrderNotificationUser>
{
    public void Configure(EntityTypeBuilder<OrderNotificationUser> entity)
    {
        entity.ToTable("OrderNotificationUser");

        entity.HasIndex(e => e.ToUserId, "IX_OrderNotificationUser_ToUserId");

        entity.Property(e => e.ScheduledTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

        entity.HasOne(d => d.OrderNotification).WithMany(p => p.OrderNotificationUsers)
                .HasForeignKey(d => d.OrderNotificationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderNotificationUser_OrderNotification");

        entity.HasOne(d => d.ToUser).WithMany(p => p.OrderNotificationUsers)
                .HasForeignKey(d => d.ToUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderNotificationUser_tblUsers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<OrderNotificationUser> entity);
}
