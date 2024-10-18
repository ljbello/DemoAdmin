using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierStatusShippingCodeCrossRefConfiguration : IEntityTypeConfiguration<SupplierStatusShippingCodeCrossRef>
{
    public void Configure(EntityTypeBuilder<SupplierStatusShippingCodeCrossRef> entity)
    {
        entity.HasKey(e => e.SupplierShippingCodeId);

        entity.ToTable("SupplierStatusShippingCodeCrossRef");

        entity.HasIndex(e => new { e.SupplierId, e.SupplierShippingCode }, "IX_SupplierStatusShippingCodeCrossRef");

        entity.Property(e => e.SupplierShippingCodeId).HasColumnName("SupplierShippingCodeID");
        entity.Property(e => e.ShippingCarrierId).HasColumnName("ShippingCarrierID");
        entity.Property(e => e.ShippingMethodId).HasColumnName("ShippingMethodID");
        entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
        entity.Property(e => e.SupplierShippingCode)
                .HasMaxLength(50)
                .IsUnicode(false);

        entity.HasOne(d => d.ShippingCarrier).WithMany(p => p.SupplierStatusShippingCodeCrossRefs)
                .HasForeignKey(d => d.ShippingCarrierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierStatusShippingCodeCrossRef_tblShippingCarriers");

        entity.HasOne(d => d.ShippingMethod).WithMany(p => p.SupplierStatusShippingCodeCrossRefs)
                .HasForeignKey(d => d.ShippingMethodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierStatusShippingCodeCrossRef_tblShippingMethods");

        entity.HasOne(d => d.Supplier).WithMany(p => p.SupplierStatusShippingCodeCrossRefs)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierStatusShippingCodeCrossRef_tblSuppliers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierStatusShippingCodeCrossRef> entity);
}
