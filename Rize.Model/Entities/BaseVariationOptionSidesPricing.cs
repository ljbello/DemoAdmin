using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class BaseVariationOptionSidesPricing
{
    public int ProductId { get; set; }

    public int ProductVariationId { get; set; }

    public int ProductOptionPriceGroupDetailId { get; set; }

    public string ProductOptionPriceGroupId { get; set; } = null!;

    public int LowerQuantityLimit { get; set; }

    public int UpperQuantityLimit { get; set; }

    public decimal AdditionalPricePerCard { get; set; }

    public string? EntityDescriptor { get; set; }

    public string? FriendlyName { get; set; }

    public bool? IsDefault { get; set; }

    public int StoreId { get; set; }

    public int? PriceGroupId { get; set; }
}
