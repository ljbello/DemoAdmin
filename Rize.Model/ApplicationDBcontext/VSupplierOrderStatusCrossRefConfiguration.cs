using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VSupplierOrderStatusCrossRefConfiguration : IEntityTypeConfiguration<VSupplierOrderStatusCrossRef>
{
    public void Configure(EntityTypeBuilder<VSupplierOrderStatusCrossRef> entity)
    {
        entity
                .HasNoKey()
                .ToView("vSupplierOrderStatusCrossRef");

        entity.Property(e => e.OrdStaDescription)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("OrdSta__Description");
        entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
        entity.Property(e => e.SupplierOrderDescription)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VSupplierOrderStatusCrossRef> entity);
}
