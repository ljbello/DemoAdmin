using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierPaperFinishMappingConfiguration : IEntityTypeConfiguration<SupplierPaperFinishMapping>
{
    public void Configure(EntityTypeBuilder<SupplierPaperFinishMapping> entity)
    {
        entity.HasKey(e => e.SupplierPaperFinishId);

        entity.ToTable("SupplierPaperFinishMapping");

        entity.HasOne(d => d.PaperFinish).WithMany(p => p.SupplierPaperFinishMappings)
                .HasForeignKey(d => d.PaperFinishId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierPaperFinishMapping_PaperFinish");

        entity.HasOne(d => d.Supplier).WithMany(p => p.SupplierPaperFinishMappings)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierPaperFinishMapping_tblSuppliers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierPaperFinishMapping> entity);
}
