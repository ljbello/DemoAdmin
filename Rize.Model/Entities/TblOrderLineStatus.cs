using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblOrderLineStatus
{
    public Guid OrderLineStatusId { get; set; }

    public int OrderLineId { get; set; }

    public int OrderStatusId { get; set; }

    public string OrderNumber { get; set; } = null!;

    public int WorkFlowId { get; set; }

    public string? TrackingNumber { get; set; }

    public int? ShippingMethodId { get; set; }

    public int? ShippingCarrierId { get; set; }

    public DateTime? ShippingDate { get; set; }

    public int SupplierId { get; set; }

    public bool SupplierOrderLine { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime RunDate { get; set; }

    public string? DataSource { get; set; }

    public string? Notes { get; set; }

    public virtual TblOrderLine OrderLine { get; set; } = null!;

    public virtual TblOrderStatus OrderStatus { get; set; } = null!;

    public virtual TblShippingMethod? ShippingMethod { get; set; }

    public virtual TblSupplier Supplier { get; set; } = null!;
}
