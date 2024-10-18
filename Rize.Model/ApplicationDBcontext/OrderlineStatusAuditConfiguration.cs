using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OrderlineStatusAuditConfiguration : IEntityTypeConfiguration<OrderlineStatusAudit>
{
    public void Configure(EntityTypeBuilder<OrderlineStatusAudit> entity)
    {
        entity.ToTable("OrderlineStatusAudit");

        entity.HasIndex(e => e.OrderLineId, "IX_OrderlineStatusAudit_OrderLineID");

        entity.Property(e => e.ModifedBy).HasDefaultValue(1);
        entity.Property(e => e.OrderLineId).HasColumnName("OrderLineID");
        entity.Property(e => e.OrderStatusChangeDate).HasColumnType("datetime");
        entity.Property(e => e.OrderStatusId).HasColumnName("OrderStatusID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<OrderlineStatusAudit> entity);
}
