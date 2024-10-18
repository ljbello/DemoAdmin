using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierPaperStockMappingConfiguration : IEntityTypeConfiguration<SupplierPaperStockMapping>
{
    public void Configure(EntityTypeBuilder<SupplierPaperStockMapping> entity)
    {
        entity.ToTable("SupplierPaperStockMapping");

        entity.HasIndex(e => e.SupplierId, "SupplierPaperStockMapping_IX1");

        entity.HasOne(d => d.Supplier).WithMany(p => p.SupplierPaperStockMappings)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierPaperStockMapping_tblSuppliers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierPaperStockMapping> entity);
}
