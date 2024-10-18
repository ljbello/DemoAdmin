using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblShippingCarrierConfiguration : IEntityTypeConfiguration<TblShippingCarrier>
{
    public void Configure(EntityTypeBuilder<TblShippingCarrier> entity)
    {
        entity.HasKey(e => e.ShiCarShippingCarrierId).HasName("tblShippingCarriers_PK");

        entity.ToTable("tblShippingCarriers");

        entity.Property(e => e.ShiCarShippingCarrierId).HasColumnName("ShiCar__ShippingCarrierID");
        entity.Property(e => e.GtsCarrierCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("GTS_CarrierCode");
        entity.Property(e => e.GtsOtherCarrierName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("GTS_OtherCarrierName");
        entity.Property(e => e.ShiCarDescription)
                .HasMaxLength(48)
                .IsUnicode(false)
                .HasColumnName("ShiCar__Description");
        entity.Property(e => e.ShiCarTrackingUrlwithPlaceholders)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("ShiCar__TrackingURLWithPlaceholders");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblShippingCarrier> entity);
}
