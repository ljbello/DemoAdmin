using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SalesBudgetByDay
{
    public int? StoreId { get; set; }

    public int? Year { get; set; }

    public DateOnly? OrderDate { get; set; }

    public string? Day { get; set; }

    public int? OffsetYear { get; set; }

    public DateOnly? OffsetDate { get; set; }

    public string? OffsetDay { get; set; }

    public int? IOrderCount { get; set; }

    public decimal? IProductSales { get; set; }

    public decimal? IShipping { get; set; }

    public decimal? IPreTaxSales { get; set; }

    public decimal? ISalesTax { get; set; }

    public decimal? ISettlement { get; set; }

    public decimal? IProductSalesBdgt { get; set; }

    public decimal? IShippingBdgt { get; set; }

    public decimal? IPreTaxSalesBdgt { get; set; }

    public decimal? ISalesTaxBdgt { get; set; }

    public decimal? ISettlementBdgt { get; set; }

    public decimal? IPreTaxSalesFcst { get; set; }

    public DateOnly? ShipDate { get; set; }

    public int? SOrderCount { get; set; }

    public decimal? SProductSales { get; set; }

    public decimal? SShipping { get; set; }

    public decimal? SPreTaxSales { get; set; }

    public decimal? SSalesTax { get; set; }

    public decimal? SSettlement { get; set; }

    public decimal? SProductSalesBdgt { get; set; }

    public decimal? SShippingBdgt { get; set; }

    public decimal? SPreTaxSalesBdgt { get; set; }

    public decimal? SSalesTaxBdgt { get; set; }

    public decimal? SSettlementBdgt { get; set; }

    public decimal? SPreTaxSalesFcst { get; set; }
}
