using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ViewProductBasePricingConfiguration : IEntityTypeConfiguration<ViewProductBasePricing>
{
    public void Configure(EntityTypeBuilder<ViewProductBasePricing> entity)
    {
        entity
                .HasNoKey()
                .ToView("viewProductBasePricing");

        entity.Property(e => e.SalePrice).HasColumnType("money");
        entity.Property(e => e.StoStoreid).HasColumnName("sto__Storeid");
        entity.Property(e => e.StoreRetailDiscount).HasColumnType("decimal(7, 4)");
        entity.Property(e => e.SupplierRetailDiscount).HasColumnType("decimal(7, 4)");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ViewProductBasePricing> entity);
}
