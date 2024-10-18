using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AnnualBudget
{
    public int? Year { get; set; }

    public int? StoreId { get; set; }

    public decimal? SubTotal { get; set; }

    public decimal? Shipping { get; set; }

    public decimal? SalesPreTax { get; set; }

    public decimal? Tax { get; set; }

    public decimal? Settlement { get; set; }
}
