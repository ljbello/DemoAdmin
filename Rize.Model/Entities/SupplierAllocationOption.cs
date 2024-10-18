using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierAllocationOption
{
    public string Geoenabled { get; set; } = null!;

    public decimal GeooverRide { get; set; }

    public bool? CanadaOverride { get; set; }

    public bool? DeliveryEstimationAudit { get; set; }
}
