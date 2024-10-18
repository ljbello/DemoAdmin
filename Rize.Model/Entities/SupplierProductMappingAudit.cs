using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierProductMappingAudit
{
    public long SupplierProductMappingAuditId { get; set; }

    public int SupplierProductMappingId { get; set; }

    public int ProductId { get; set; }

    public int SupplierId { get; set; }

    public string ActionTaken { get; set; } = null!;

    public DateTime DateChanged { get; set; }

    public bool? SaveRecord { get; set; }
}
