using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierProductTypeMappingByStoreConfiguration : IEntityTypeConfiguration<SupplierProductTypeMappingByStore>
{
    public void Configure(EntityTypeBuilder<SupplierProductTypeMappingByStore> entity)
    {
        entity.ToTable("SupplierProductTypeMappingByStore");

        entity.Property(e => e.SupplierProductTypeMappingByStoreId).HasColumnName("SupplierProductTypeMappingByStoreID");
        entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");
        entity.Property(e => e.StoreId).HasColumnName("StoreID");
        entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierProductTypeMappingByStore> entity);
}
