using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierProductMappingAuditConfiguration : IEntityTypeConfiguration<SupplierProductMappingAudit>
{
    public void Configure(EntityTypeBuilder<SupplierProductMappingAudit> entity)
    {
        entity.ToTable("SupplierProductMappingAudit");

        entity.HasIndex(e => new { e.ProductId, e.SupplierId, e.DateChanged }, "SupplierProductMappingAudit_IX1");

        entity.Property(e => e.SupplierProductMappingAuditId).HasColumnName("SupplierProductMappingAuditID");
        entity.Property(e => e.ActionTaken)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("Added");
        entity.Property(e => e.DateChanged)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierProductMappingAudit> entity);
}
