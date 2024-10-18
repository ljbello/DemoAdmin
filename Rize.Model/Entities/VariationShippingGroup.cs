using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class VariationShippingGroup
{
    public int Id { get; set; }

    public int StoreId { get; set; }

    public int ShippingGroupId { get; set; }

    public int VariationId { get; set; }

    public bool UseGlobalRate { get; set; }

    public bool Active { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public virtual ShippingGroup ShippingGroup { get; set; } = null!;

    public virtual ProductVariation Variation { get; set; } = null!;
}
