using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OrderTagConfiguration : IEntityTypeConfiguration<OrderTag>
{
    public void Configure(EntityTypeBuilder<OrderTag> entity)
    {
        entity.ToTable("OrderTag");

        entity.HasIndex(e => e.OrderId, "OrderTag_IX1");

        entity.HasIndex(e => e.TagId, "OrderTag_IX2");

        entity.HasIndex(e => e.OrderLineId, "OrderTag_IX3");

        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

        entity.HasOne(d => d.Order).WithMany(p => p.OrderTags)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderTag_Order");

        entity.HasOne(d => d.OrderLine).WithMany(p => p.OrderTags)
                .HasForeignKey(d => d.OrderLineId)
                .HasConstraintName("FK_OrderTag_tblOrderLines");

        entity.HasOne(d => d.Tag).WithMany(p => p.OrderTags)
                .HasForeignKey(d => d.TagId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderTag_OrderTagKey");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<OrderTag> entity);
}
