using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierAllocationVariationByStoreConfiguration : IEntityTypeConfiguration<SupplierAllocationVariationByStore>
{
    public void Configure(EntityTypeBuilder<SupplierAllocationVariationByStore> entity)
    {
        entity
                .HasNoKey()
                .ToTable("SupplierAllocationVariationByStore");

        entity.Property(e => e.StoreId).HasColumnName("StoreID");
        entity.Property(e => e.SupplierAllocationVariationByStoreId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SupplierAllocationVariationByStoreID");
        entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
        entity.Property(e => e.VariationId).HasColumnName("VariationID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierAllocationVariationByStore> entity);
}
