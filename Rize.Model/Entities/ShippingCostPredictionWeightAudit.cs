using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ShippingCostPredictionWeightAudit
{
    public int OrderId { get; set; }

    public int OrderPartId { get; set; }

    public int OrderLineId { get; set; }

    public string Type { get; set; } = null!;

    public decimal Weight { get; set; }

    public DateTime CreatedDate { get; set; }
}
