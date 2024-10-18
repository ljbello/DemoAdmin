using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OrderAllocationAuditConfiguration : IEntityTypeConfiguration<OrderAllocationAudit>
{
    public void Configure(EntityTypeBuilder<OrderAllocationAudit> entity)
    {
        entity.ToTable("OrderAllocationAudit");

        entity.Property(e => e.OrderAllocationAuditId).HasColumnName("OrderAllocationAuditID");
        entity.Property(e => e.InsertDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Operation)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.OrderId).HasColumnName("OrderID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<OrderAllocationAudit> entity);
}
