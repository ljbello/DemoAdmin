using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ViewOrderSummation
{
    public int OrdOrderId { get; set; }

    public int? Quantity { get; set; }

    public decimal? CreditAmount { get; set; }

    public decimal? AdjustmentAmount { get; set; }

    public decimal? PaidAmount { get; set; }
}
