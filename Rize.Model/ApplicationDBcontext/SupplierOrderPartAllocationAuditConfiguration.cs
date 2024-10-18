using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierOrderPartAllocationAuditConfiguration : IEntityTypeConfiguration<SupplierOrderPartAllocationAudit>
{
    public void Configure(EntityTypeBuilder<SupplierOrderPartAllocationAudit> entity)
    {
        entity.HasKey(e => e.SupplierOrderPartAllocationAudit1);

        entity.ToTable("SupplierOrderPartAllocationAudit");

        entity.HasIndex(e => e.OrderPartId, "SupplierOrderPartAllocationAudit_IX1");

        entity.Property(e => e.SupplierOrderPartAllocationAudit1).HasColumnName("SupplierOrderPartAllocationAudit");
        entity.Property(e => e.Comment).HasColumnType("ntext");
        entity.Property(e => e.EventDateTime).HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierOrderPartAllocationAudit> entity);
}
