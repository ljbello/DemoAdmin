using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierProductMappingInventoryTracking
{
    public long SupplierProductMappingInventoryTrackingId { get; set; }

    public int? ProductId { get; set; }

    public int? SupplierId { get; set; }

    public int? AvailableQuantity { get; set; }

    public int? TotalQuantity { get; set; }

    public int? InFlight { get; set; }

    public int? LowThresholdQuantity { get; set; }

    public DateTime AuditTimeStamp { get; set; }
}
