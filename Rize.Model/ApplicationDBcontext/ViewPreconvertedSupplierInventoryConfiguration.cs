using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ViewPreconvertedSupplierInventoryConfiguration : IEntityTypeConfiguration<ViewPreconvertedSupplierInventory>
{
    public void Configure(EntityTypeBuilder<ViewPreconvertedSupplierInventory> entity)
    {
        entity
                .HasNoKey()
                .ToView("viewPreconvertedSupplierInventory");

        entity.Property(e => e.LastUpdated).HasColumnType("datetime");
        entity.Property(e => e.ProSupplierProductNumber)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("Pro__SupplierProductNumber");
        entity.Property(e => e.SupName)
                .HasMaxLength(48)
                .IsUnicode(false)
                .HasColumnName("Sup__Name");
        entity.Property(e => e.SupProStockNumber)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("SupPro__StockNumber");
        entity.Property(e => e.SupSupplierId).HasColumnName("Sup__SupplierID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ViewPreconvertedSupplierInventory> entity);
}
