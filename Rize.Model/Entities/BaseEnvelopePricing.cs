using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class BaseEnvelopePricing
{
    public int SupplierEnvelopeId { get; set; }

    public string SupplierEnvelopeCode { get; set; } = null!;

    public string? EnvelopeTypeId { get; set; }

    public string Description { get; set; } = null!;

    public int LowerQuantityLimit { get; set; }

    public int UpperQuantityLimit { get; set; }

    public decimal AdditionalCost { get; set; }

    public string ProductOptionPriceGroupId { get; set; } = null!;

    public int IsPhotoCard { get; set; }

    public decimal? SupplierEnvelopeAmount { get; set; }

    public int StoreId { get; set; }
}
