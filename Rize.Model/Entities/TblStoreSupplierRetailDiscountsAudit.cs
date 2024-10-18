using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblStoreSupplierRetailDiscountsAudit
{
    public int TblStoreSupplierRetailDiscountsAuditId { get; set; }

    public int? StoreSupplierRetailDiscountId { get; set; }

    public int? PricingGroupIdOld { get; set; }

    public int? PricingGroupIdNew { get; set; }

    public DateTime? AuditTimeStamp { get; set; }
}
