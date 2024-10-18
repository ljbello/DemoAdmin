using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class VSupplierOrderStatusCrossRef
{
    public int OrderStatusId { get; set; }

    public int SupplierId { get; set; }

    public int SupplierOrderStatusCrossRefId { get; set; }

    public string SupplierOrderDescription { get; set; } = null!;

    public string OrdStaDescription { get; set; } = null!;

    public int? WorkFlowId { get; set; }
}
