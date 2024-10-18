using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class BaseProductPricingGroup
{
    public int ProductId { get; set; }

    public int? VariationPricingGroupId { get; set; }

    public int StoStoreId { get; set; }

    public int ProductVariationId { get; set; }
}
