using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierProductMappingInventoryTrackingConfiguration : IEntityTypeConfiguration<SupplierProductMappingInventoryTracking>
{
    public void Configure(EntityTypeBuilder<SupplierProductMappingInventoryTracking> entity)
    {
        entity.ToTable("SupplierProductMappingInventoryTracking");

        entity.Property(e => e.SupplierProductMappingInventoryTrackingId).HasColumnName("SupplierProductMappingInventoryTrackingID");
        entity.Property(e => e.AuditTimeStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierProductMappingInventoryTracking> entity);
}
