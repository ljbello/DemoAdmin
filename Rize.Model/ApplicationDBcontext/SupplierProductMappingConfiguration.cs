using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierProductMappingConfiguration : IEntityTypeConfiguration<SupplierProductMapping>
{
    public void Configure(EntityTypeBuilder<SupplierProductMapping> entity)
    {
        entity.ToTable("SupplierProductMapping", tb => tb.HasTrigger("SupplierProductMapping_tr"));

        entity.HasOne(d => d.Product).WithMany(p => p.SupplierProductMappings)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierProductMapping_tblProducts");

        entity.HasOne(d => d.Supplier).WithMany(p => p.SupplierProductMappings)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierProductMapping_tblSuppliers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierProductMapping> entity);
}
