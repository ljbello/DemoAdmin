using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierAllocationZipCodeAreaConfiguration : IEntityTypeConfiguration<SupplierAllocationZipCodeArea>
{
    public void Configure(EntityTypeBuilder<SupplierAllocationZipCodeArea> entity)
    {
        entity.HasKey(e => e.ZipCodeAreaId);

        entity.ToTable("SupplierAllocationZipCodeArea");

        entity.Property(e => e.ZipCodeAreaId).HasColumnName("ZipCodeAreaID");
        entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
        entity.Property(e => e.Zip3)
                .HasMaxLength(3)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierAllocationZipCodeArea> entity);
}
