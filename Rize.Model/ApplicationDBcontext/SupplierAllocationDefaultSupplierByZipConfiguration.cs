using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierAllocationDefaultSupplierByZipConfiguration : IEntityTypeConfiguration<SupplierAllocationDefaultSupplierByZip>
{
    public void Configure(EntityTypeBuilder<SupplierAllocationDefaultSupplierByZip> entity)
    {
        entity
                .HasNoKey()
                .ToTable("SupplierAllocationDefaultSupplierByZip");

        entity.Property(e => e.DefaultSupplierId).HasColumnName("DefaultSupplierID");
        entity.Property(e => e.Zip3)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierAllocationDefaultSupplierByZip> entity);
}
