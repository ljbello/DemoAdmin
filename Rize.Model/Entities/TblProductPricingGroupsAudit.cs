using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblProductPricingGroupsAudit
{
    public int ProPriGroAudProductPricingGroupAuditId { get; set; }

    public int ProProductId { get; set; }

    public DateTime ProPriGroAudLastUpdatedDate { get; set; }

    public int? ProPriGroAudLastUpdatedByUserId { get; set; }

    public int? ProPriGroAudPricingGroupIdold { get; set; }

    public int? ProPriGroAudPricingGroupIdnew { get; set; }

    public int? StoreId { get; set; }
}
