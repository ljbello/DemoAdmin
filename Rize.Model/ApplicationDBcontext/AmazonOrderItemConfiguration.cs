using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AmazonOrderItemConfiguration : IEntityTypeConfiguration<AmazonOrderItem>
{
    public void Configure(EntityTypeBuilder<AmazonOrderItem> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__AmazonOr__3214EC07C0A8966C");

        entity.ToTable("AmazonOrderItem");

        entity.Property(e => e.AmazonSku)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.OrderItemId)
                .HasMaxLength(30)
                .IsUnicode(false);

        entity.HasOne(d => d.AmazonOrderRef).WithMany(p => p.AmazonOrderItems)
                .HasForeignKey(d => d.AmazonOrderRefId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AmazonOrderItem_AmazonOrder");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AmazonOrderItem> entity);
}
