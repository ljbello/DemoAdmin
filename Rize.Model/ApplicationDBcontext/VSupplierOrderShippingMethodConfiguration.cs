using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VSupplierOrderShippingMethodConfiguration : IEntityTypeConfiguration<VSupplierOrderShippingMethod>
{
    public void Configure(EntityTypeBuilder<VSupplierOrderShippingMethod> entity)
    {
        entity
                .HasNoKey()
                .ToView("vSupplierOrderShippingMethod");

        entity.Property(e => e.ShiCarDescription)
                .HasMaxLength(48)
                .IsUnicode(false)
                .HasColumnName("ShiCar__Description");
        entity.Property(e => e.ShiMetStrDescription)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("ShiMet__strDescription");
        entity.Property(e => e.ShippingCarrierId).HasColumnName("ShippingCarrierID");
        entity.Property(e => e.ShippingMethodId).HasColumnName("ShippingMethodID");
        entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
        entity.Property(e => e.SupplierShippingCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.SupplierShippingCodeId).HasColumnName("SupplierShippingCodeID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VSupplierOrderShippingMethod> entity);
}
