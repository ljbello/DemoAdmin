using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductStockRequestsAudit
{
    public long ProductStockRequestsAudit1 { get; set; }

    public string? XmlRequestStock { get; set; }

    public string? XmlResponseStock { get; set; }

    public DateTime? AuditTs { get; set; }
}
