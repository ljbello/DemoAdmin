using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierAllocationOptionConfiguration : IEntityTypeConfiguration<SupplierAllocationOption>
{
    public void Configure(EntityTypeBuilder<SupplierAllocationOption> entity)
    {
        entity
                .HasNoKey()
                .ToTable("SupplierAllocationOption");

        entity.Property(e => e.DeliveryEstimationAudit).HasDefaultValue(false);
        entity.Property(e => e.Geoenabled)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GEOEnabled");
        entity.Property(e => e.GeooverRide)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("GEOOverRide");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierAllocationOption> entity);
}
