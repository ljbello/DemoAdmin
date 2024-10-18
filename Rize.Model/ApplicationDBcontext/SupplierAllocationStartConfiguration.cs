using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierAllocationStartConfiguration : IEntityTypeConfiguration<SupplierAllocationStart>
{
    public void Configure(EntityTypeBuilder<SupplierAllocationStart> entity)
    {
        entity.ToTable("SupplierAllocationStart");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.SupplierAllocationStartDate).HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierAllocationStart> entity);
}
