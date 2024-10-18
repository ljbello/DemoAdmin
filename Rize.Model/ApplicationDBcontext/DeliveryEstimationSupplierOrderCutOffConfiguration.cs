using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class DeliveryEstimationSupplierOrderCutOffConfiguration : IEntityTypeConfiguration<DeliveryEstimationSupplierOrderCutOff>
{
    public void Configure(EntityTypeBuilder<DeliveryEstimationSupplierOrderCutOff> entity)
    {
        entity.HasKey(e => e.DeliveryEstimationSupplierOrderCutOffId).HasName("PK_SupplierOrderCutoff");

        entity.ToTable("DeliveryEstimationSupplierOrderCutOff");

        entity.HasIndex(e => e.SupplierId, "DeliveryEstimationSupplierOrderCutOff_IX1");

        entity.Property(e => e.DeliveryEstimationSupplierOrderCutOffId).HasColumnName("DeliveryEstimationSupplierOrderCutOffID");
        entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

        entity.HasOne(d => d.Supplier).WithMany(p => p.DeliveryEstimationSupplierOrderCutOffs)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierOrderCutoff_tblSuppliers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<DeliveryEstimationSupplierOrderCutOff> entity);
}
