using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierOrderPartAllocationAudit
{
    public int SupplierOrderPartAllocationAudit1 { get; set; }

    public int OrderPartId { get; set; }

    public DateTime EventDateTime { get; set; }

    public string? Comment { get; set; }
}
