using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class VariationPricingGroupDefault
{
    public int PricingGroupId { get; set; }

    public int VariationId { get; set; }

    public int ProductTypeId { get; set; }

    public bool IsDefault { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public int StoreId { get; set; }

    public virtual TblUser CreatedByNavigation { get; set; } = null!;

    public virtual ProductType ProductType { get; set; } = null!;

    public virtual Store Store { get; set; } = null!;

    public virtual ProductVariation Variation { get; set; } = null!;
}
