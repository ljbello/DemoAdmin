using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblShippingMethodLookupConfiguration : IEntityTypeConfiguration<TblShippingMethodLookup>
{
    public void Configure(EntityTypeBuilder<TblShippingMethodLookup> entity)
    {
        entity
                .HasNoKey()
                .ToTable("tblShippingMethodLookup");

        entity.Property(e => e.MethodLookupId).HasColumnName("MethodLookup_ID");
        entity.Property(e => e.ServiceLevel)
                .HasMaxLength(3)
                .HasColumnName("Service_Level");
        entity.Property(e => e.ShipMethod)
                .HasMaxLength(20)
                .HasColumnName("Ship_Method");
        entity.Property(e => e.ShippingMethodsId).HasColumnName("ShippingMethodsID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblShippingMethodLookup> entity);
}
