using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class VwDashboardShipdate
{
    public int OrdOrderId { get; set; }

    public DateTime? EarliestShipDate { get; set; }

    public DateTime? LargestShipDate { get; set; }
}
