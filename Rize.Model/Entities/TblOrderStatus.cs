using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblOrderStatus
{
    public int OrdStaOrderStatusId { get; set; }

    public string OrdStaDescription { get; set; } = null!;

    public int OrdStaDisplaySequence { get; set; }

    public string? OrdStaFriendlyDescription { get; set; }

    public bool Display { get; set; }

    public int? WorkflowId { get; set; }

    public string? ColorCode { get; set; }

    public virtual ICollection<SupplierOrderStatusCrossRef> SupplierOrderStatusCrossRefs { get; set; } = new List<SupplierOrderStatusCrossRef>();

    public virtual ICollection<SupplierOrderStatusInvalidPo> SupplierOrderStatusInvalidPos { get; set; } = new List<SupplierOrderStatusInvalidPo>();

    public virtual ICollection<TblOrderLineStatus> TblOrderLineStatuses { get; set; } = new List<TblOrderLineStatus>();

    public virtual ICollection<TblOrderLine> TblOrderLines { get; set; } = new List<TblOrderLine>();
}
