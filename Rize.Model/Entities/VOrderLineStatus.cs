using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class VOrderLineStatus
{
    public string OrderNumber { get; set; } = null!;

    public int WorkFlowId { get; set; }

    public int OrderStatusId { get; set; }

    public string OrdStaDescription { get; set; } = null!;

    public string? TrackingNumber { get; set; }

    public string ShiMetStrDescription { get; set; } = null!;

    public DateTime? ShippingDate { get; set; }

    public string SupName { get; set; } = null!;

    public int OrderLineId { get; set; }

    public bool SupplierOrderLine { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime RunDate { get; set; }

    public string? DataSource { get; set; }

    public string? Notes { get; set; }
}
