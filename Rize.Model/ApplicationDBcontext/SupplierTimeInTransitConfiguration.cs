using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierTimeInTransitConfiguration : IEntityTypeConfiguration<SupplierTimeInTransit>
{
    public void Configure(EntityTypeBuilder<SupplierTimeInTransit> entity)
    {
        entity.HasKey(e => new { e.SupplierId, e.DestinationPostalCode });

        entity.ToTable("SupplierTimeInTransit");

        entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
        entity.Property(e => e.DestinationPostalCode)
                .HasMaxLength(25)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierTimeInTransit> entity);
}
