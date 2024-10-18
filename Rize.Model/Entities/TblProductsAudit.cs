using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblProductsAudit
{
    public int ProAudProductAuditId { get; set; }

    public int ProProductId { get; set; }

    public DateTime ProAudLastUpdatedDate { get; set; }

    public int ProAudLastUpdatedByUserId { get; set; }

    public int? ProAudSupplierIdold { get; set; }

    public int? ProAudSupplierIdnew { get; set; }

    public string? ProAudSupplierProductNumberOld { get; set; }

    public string? ProAudSupplierProductNumberNew { get; set; }

    public int? ProAudProductStatusIdold { get; set; }

    public int? ProAudProductStatusIdnew { get; set; }
}
