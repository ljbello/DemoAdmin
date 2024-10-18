using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductsToBeImportedConfiguration : IEntityTypeConfiguration<ProductsToBeImported>
{
    public void Configure(EntityTypeBuilder<ProductsToBeImported> entity)
    {
        entity.ToTable("ProductsToBeImported");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.DateImported).HasColumnType("datetime");
        entity.Property(e => e.ProProductNumber)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("Pro__ProductNumber");
        entity.Property(e => e.StoStoreId).HasColumnName("Sto__StoreID");
        entity.Property(e => e.SupSupplierId).HasColumnName("Sup__SupplierID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductsToBeImported> entity);
}
