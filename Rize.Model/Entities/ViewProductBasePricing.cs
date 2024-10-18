using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ViewProductBasePricing
{
    public int? ProductId { get; set; }

    public decimal? SupplierRetailDiscount { get; set; }

    public decimal? StoreRetailDiscount { get; set; }

    public int? RetailPrice { get; set; }

    public int? NumberVariant { get; set; }

    public int? MaxRetailPrice { get; set; }

    public decimal? SalePrice { get; set; }

    public int StoStoreid { get; set; }
}
