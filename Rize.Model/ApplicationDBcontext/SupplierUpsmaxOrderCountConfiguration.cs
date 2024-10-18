using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierUpsmaxOrderCountConfiguration : IEntityTypeConfiguration<SupplierUpsmaxOrderCount>
{
    public void Configure(EntityTypeBuilder<SupplierUpsmaxOrderCount> entity)
    {
        entity.ToTable("SupplierUPSMaxOrderCount");

        entity.Property(e => e.Id).HasColumnName("ID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierUpsmaxOrderCount> entity);
}
