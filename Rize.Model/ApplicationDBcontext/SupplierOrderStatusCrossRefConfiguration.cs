using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierOrderStatusCrossRefConfiguration : IEntityTypeConfiguration<SupplierOrderStatusCrossRef>
{
    public void Configure(EntityTypeBuilder<SupplierOrderStatusCrossRef> entity)
    {
        entity.ToTable("SupplierOrderStatusCrossRef");

        entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
        entity.Property(e => e.SupplierOrderDescription)
                .HasMaxLength(50)
                .IsUnicode(false);

        entity.HasOne(d => d.OrderStatus).WithMany(p => p.SupplierOrderStatusCrossRefs)
                .HasForeignKey(d => d.OrderStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierOrderStatusCrossRef_tblOrderStatuses");

        entity.HasOne(d => d.Supplier).WithMany(p => p.SupplierOrderStatusCrossRefs)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierOrderStatusCrossRef_tblSuppliers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierOrderStatusCrossRef> entity);
}
