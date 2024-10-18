using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblStoreRetailDiscount
{
    public int StoRetDisStoreRetailDiscountId { get; set; }

    public int StoStoreId { get; set; }

    public int StoRetDisLowerLimit { get; set; }

    public int StoRetDisUpperLimit { get; set; }

    public decimal StoRetDisDiscount { get; set; }

    public int PriGroPricingGroupId { get; set; }

    public virtual Store StoStore { get; set; } = null!;

    public virtual TblPricingGroup TblPricingGroup { get; set; } = null!;
}
