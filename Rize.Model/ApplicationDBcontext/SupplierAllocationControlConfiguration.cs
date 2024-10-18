using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierAllocationControlConfiguration : IEntityTypeConfiguration<SupplierAllocationControl>
{
    public void Configure(EntityTypeBuilder<SupplierAllocationControl> entity)
    {
        entity.HasKey(e => e.SupplierId);

        entity.ToTable("SupplierAllocationControl");

        entity.HasIndex(e => new { e.SupplierId, e.EnabledforAllocation }, "SupplierAllocation_IX1");

        entity.Property(e => e.SupplierId)
                .ValueGeneratedNever()
                .HasColumnName("SupplierID");
        entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.SkipLevelDpallocation).HasColumnName("SkipLevelDPAllocation");
        entity.Property(e => e.SupplierName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.VariableAddressEnabled).HasDefaultValue(true);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierAllocationControl> entity);
}
