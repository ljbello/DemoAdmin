using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierOrderStatusInvalidPo
{
    public Guid SupplierOrderStatusInvalidPoId { get; set; }

    public string SupplierOrderNumber { get; set; } = null!;

    public int SupplierId { get; set; }

    public string? OrderNumber { get; set; }

    public int? OrderStatusId { get; set; }

    public string? TrackingNumber { get; set; }

    public int? ShippingMethodId { get; set; }

    public int? ShippingCarrierId { get; set; }

    public DateTime? StatusDate { get; set; }

    public DateTime RunDate { get; set; }

    public DateTime CreationDate { get; set; }

    public string? Discrepancy { get; set; }

    public virtual TblOrderStatus? OrderStatus { get; set; }

    public virtual TblSupplier Supplier { get; set; } = null!;
}
