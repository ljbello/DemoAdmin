using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierOrderStatusCrossRef
{
    public int SupplierOrderStatusCrossRefId { get; set; }

    public int SupplierId { get; set; }

    public string SupplierOrderDescription { get; set; } = null!;

    public int OrderStatusId { get; set; }

    public virtual TblOrderStatus OrderStatus { get; set; } = null!;

    public virtual TblSupplier Supplier { get; set; } = null!;
}
