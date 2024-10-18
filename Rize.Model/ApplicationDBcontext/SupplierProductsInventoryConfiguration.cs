using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierProductsInventoryConfiguration : IEntityTypeConfiguration<SupplierProductsInventory>
{
    public void Configure(EntityTypeBuilder<SupplierProductsInventory> entity)
    {
        entity.ToTable("SupplierProductsInventory");

        entity.Property(e => e.AccountNumber)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        entity.Property(e => e.SupplierProductSku)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Weight).HasColumnType("decimal(15, 5)");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierProductsInventory> entity);
}
