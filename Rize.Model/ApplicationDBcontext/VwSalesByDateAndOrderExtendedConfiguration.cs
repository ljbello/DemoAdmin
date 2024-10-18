using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VwSalesByDateAndOrderExtendedConfiguration : IEntityTypeConfiguration<VwSalesByDateAndOrderExtended>
{
    public void Configure(EntityTypeBuilder<VwSalesByDateAndOrderExtended> entity)
    {
        entity
                .HasNoKey()
                .ToView("vw_sales_by_date_and_order_extended");

        entity.Property(e => e.CusAddCompany)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("CusAdd__Company");
        entity.Property(e => e.EarliestShipDate).HasColumnType("smalldatetime");
        entity.Property(e => e.IOrderTotalPieces).HasColumnName("iOrderTotalPieces");
        entity.Property(e => e.IOrderTotalQuantity).HasColumnName("iOrderTotalQuantity");
        entity.Property(e => e.InvoiceTotal).HasColumnType("money");
        entity.Property(e => e.LargestShipDate).HasColumnType("smalldatetime");
        entity.Property(e => e.OrdOrderId).HasColumnName("Ord__OrderID");
        entity.Property(e => e.OrdPlacedDate)
                .HasColumnType("datetime")
                .HasColumnName("Ord__PlacedDate");
        entity.Property(e => e.OrderDate).HasColumnType("datetime");
        entity.Property(e => e.OrderNumber)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.Profit).HasColumnType("money");
        entity.Property(e => e.ProfitPercentage)
                .HasColumnType("money")
                .HasColumnName("Profit Percentage");
        entity.Property(e => e.Settlement).HasColumnType("money");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VwSalesByDateAndOrderExtended> entity);
}
