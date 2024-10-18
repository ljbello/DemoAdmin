using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class LegacyOrderDetailConfiguration : IEntityTypeConfiguration<LegacyOrderDetail>
{
    public void Configure(EntityTypeBuilder<LegacyOrderDetail> entity)
    {
        entity.HasKey(e => new { e.OrderNumber, e.OrderDetailId });

        entity.ToTable("LegacyOrderDetail");

        entity.HasIndex(e => new { e.OrderNumber, e.ShipAddrState }, "LegacyOrderDetail_IX1");

        entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");
        entity.Property(e => e.ConvertedCarrierId).HasColumnName("ConvertedCarrierID");
        entity.Property(e => e.ConvertedShipMethodId).HasColumnName("ConvertedShipMethodID");
        entity.Property(e => e.GroupItem)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        entity.Property(e => e.Item)
                .HasMaxLength(15)
                .IsUnicode(false);
        entity.Property(e => e.ItemDescription)
                .HasMaxLength(75)
                .IsUnicode(false);
        entity.Property(e => e.LineStatus)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        entity.Property(e => e.ShipAddr1)
                .HasMaxLength(35)
                .IsUnicode(false);
        entity.Property(e => e.ShipAddr2)
                .HasMaxLength(35)
                .IsUnicode(false);
        entity.Property(e => e.ShipAddrCity)
                .HasMaxLength(35)
                .IsUnicode(false);
        entity.Property(e => e.ShipAddrState)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        entity.Property(e => e.ShipAddrZip)
                .HasMaxLength(12)
                .IsUnicode(false);
        entity.Property(e => e.ShipCarrier)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        entity.Property(e => e.ShipMethod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<LegacyOrderDetail> entity);
}
