using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OrderNotificationReplyConfiguration : IEntityTypeConfiguration<OrderNotificationReply>
{
    public void Configure(EntityTypeBuilder<OrderNotificationReply> entity)
    {
        entity.ToTable("OrderNotificationReply");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.Message).HasMaxLength(800);

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.OrderNotificationReplies)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderNotificationReply_tblUsers");

        entity.HasOne(d => d.OrderNotification).WithMany(p => p.OrderNotificationReplies)
                .HasForeignKey(d => d.OrderNotificationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderNotificationReply_OrderNotification");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<OrderNotificationReply> entity);
}
