using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class CustomerMetricsOrderProcessing
{
    public long ProcessId { get; set; }

    public long OrderId { get; set; }

    public string ProcessStatus { get; set; } = null!;

    public DateTime? PlacedDate { get; set; }
}
