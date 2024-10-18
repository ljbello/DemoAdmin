using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierPricingDetail
{
    public int SupPriPricingGroupId { get; set; }

    public int LowerQuantityLimit { get; set; }

    public int HigherQuantityLimit { get; set; }

    public decimal PricePerPiece { get; set; }

    public int Increment { get; set; }

    public virtual TblSupplierPricing SupPriPricingGroup { get; set; } = null!;
}
