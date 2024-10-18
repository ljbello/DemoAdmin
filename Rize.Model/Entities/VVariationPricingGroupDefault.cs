using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class VVariationPricingGroupDefault
{
    public int PricingGroupId { get; set; }

    public int VariationId { get; set; }

    public string? ProductVariation { get; set; }

    public int ProductTypeId { get; set; }

    public string ProductType { get; set; } = null!;

    public bool IsDefault { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public string? Username { get; set; }

    public string VariationPricingGroup { get; set; } = null!;

    public int StoreId { get; set; }

    public bool Active { get; set; }
}
