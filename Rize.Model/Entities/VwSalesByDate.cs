using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class VwSalesByDate
{
    public DateTime? OrderDate { get; set; }

    public int? NumberOfOrders { get; set; }

    public int? NumberOfOrderLines { get; set; }

    public decimal? SettlementDollarAmount { get; set; }
}
