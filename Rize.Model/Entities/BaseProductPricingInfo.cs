using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class BaseProductPricingInfo
{
    public int ProductId { get; set; }

    public int SupplierId { get; set; }

    public int ProductVariationId { get; set; }

    public int? VariationPricingGroupId { get; set; }

    public int? DiscountPriceGroupId { get; set; }

    public bool IsPhotoCard { get; set; }

    public int ProductTypeId { get; set; }

    public bool? IsBusinessCard { get; set; }

    public int StoStoreId { get; set; }
}
