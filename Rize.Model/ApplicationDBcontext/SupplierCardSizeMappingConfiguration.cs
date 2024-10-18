using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierCardSizeMappingConfiguration : IEntityTypeConfiguration<SupplierCardSizeMapping>
{
    public void Configure(EntityTypeBuilder<SupplierCardSizeMapping> entity)
    {
        entity.ToTable("SupplierCardSizeMapping");

        entity.HasOne(d => d.CardSize).WithMany(p => p.SupplierCardSizeMappings)
                .HasForeignKey(d => d.CardSizeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierCardSizeMapping_CardSize");

        entity.HasOne(d => d.Supplier).WithMany(p => p.SupplierCardSizeMappings)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierCardSizeMapping_tblSuppliers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierCardSizeMapping> entity);
}
