using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VwSalesByDateAndOrderConfiguration : IEntityTypeConfiguration<VwSalesByDateAndOrder>
{
    public void Configure(EntityTypeBuilder<VwSalesByDateAndOrder> entity)
    {
        entity
                .HasNoKey()
                .ToView("vw_sales_by_date_and_order");

        entity.Property(e => e.OrdOrderId).HasColumnName("Ord__OrderID");
        entity.Property(e => e.OrderDate).HasColumnType("datetime");
        entity.Property(e => e.SettlementDollarAmount).HasColumnType("money");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VwSalesByDateAndOrder> entity);
}
