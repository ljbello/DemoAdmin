using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class OrderAllocationAudit
{
    public int OrderAllocationAuditId { get; set; }

    public long OrderId { get; set; }

    public DateTime InsertDateTime { get; set; }

    public string Operation { get; set; } = null!;
}
