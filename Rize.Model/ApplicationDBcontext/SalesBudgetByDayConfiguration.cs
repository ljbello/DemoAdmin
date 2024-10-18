using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SalesBudgetByDayConfiguration : IEntityTypeConfiguration<SalesBudgetByDay>
{
    public void Configure(EntityTypeBuilder<SalesBudgetByDay> entity)
    {
        entity
                .HasNoKey()
                .ToTable("SalesBudgetByDay");

        entity.HasIndex(e => e.OrderDate, "SalesBudgetByDay_IX1");

        entity.HasIndex(e => e.OffsetDate, "SalesBudgetByDay_IX2");

        entity.Property(e => e.Day).HasMaxLength(30);
        entity.Property(e => e.IOrderCount).HasColumnName("I_OrderCount");
        entity.Property(e => e.IPreTaxSales)
                .HasColumnType("money")
                .HasColumnName("I_PreTaxSales");
        entity.Property(e => e.IPreTaxSalesBdgt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("I_PreTaxSales_BDGT");
        entity.Property(e => e.IPreTaxSalesFcst)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("I_PreTaxSales_FCST");
        entity.Property(e => e.IProductSales)
                .HasColumnType("money")
                .HasColumnName("I_ProductSales");
        entity.Property(e => e.IProductSalesBdgt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("I_ProductSales_BDGT");
        entity.Property(e => e.ISalesTax)
                .HasColumnType("money")
                .HasColumnName("I_SalesTax");
        entity.Property(e => e.ISalesTaxBdgt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("I_SalesTax_BDGT");
        entity.Property(e => e.ISettlement)
                .HasColumnType("money")
                .HasColumnName("I_Settlement");
        entity.Property(e => e.ISettlementBdgt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("I_Settlement_BDGT");
        entity.Property(e => e.IShipping)
                .HasColumnType("money")
                .HasColumnName("I_Shipping");
        entity.Property(e => e.IShippingBdgt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("I_Shipping_BDGT");
        entity.Property(e => e.OffsetDay).HasMaxLength(30);
        entity.Property(e => e.SOrderCount).HasColumnName("S_OrderCount");
        entity.Property(e => e.SPreTaxSales)
                .HasColumnType("money")
                .HasColumnName("S_PreTaxSales");
        entity.Property(e => e.SPreTaxSalesBdgt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("S_PreTaxSales_BDGT");
        entity.Property(e => e.SPreTaxSalesFcst)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("S_PreTaxSales_FCST");
        entity.Property(e => e.SProductSales)
                .HasColumnType("money")
                .HasColumnName("S_ProductSales");
        entity.Property(e => e.SProductSalesBdgt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("S_ProductSales_BDGT");
        entity.Property(e => e.SSalesTax)
                .HasColumnType("money")
                .HasColumnName("S_SalesTax");
        entity.Property(e => e.SSalesTaxBdgt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("S_SalesTax_BDGT");
        entity.Property(e => e.SSettlement)
                .HasColumnType("money")
                .HasColumnName("S_Settlement");
        entity.Property(e => e.SSettlementBdgt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("S_Settlement_BDGT");
        entity.Property(e => e.SShipping)
                .HasColumnType("money")
                .HasColumnName("S_Shipping");
        entity.Property(e => e.SShippingBdgt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("S_Shipping_BDGT");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SalesBudgetByDay> entity);
}
