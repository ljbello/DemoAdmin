using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class VwDashboardShipdatesSettlement
{
    public DateTime? OrderDate { get; set; }

    public int OrdOrderId { get; set; }

    public int? NumberOfOrderLines { get; set; }

    public decimal Settlement { get; set; }

    public DateTime? LargestShipDate { get; set; }
}
