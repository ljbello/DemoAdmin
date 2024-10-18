using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductVariationOptionGroup
{
    public int ProductVariationOptionGroupId { get; set; }

    public int? ProductVariationId { get; set; }

    public int? StoreId { get; set; }

    public string? ProductOptionPriceGroupId { get; set; }

    public bool? Active { get; set; }

    public string? FriendlyName { get; set; }

    public virtual ProductVariation? ProductVariation { get; set; }

    public virtual Store? Store { get; set; }
}
