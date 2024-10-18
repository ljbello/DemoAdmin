using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductProductVariation
{
    public int ProductId { get; set; }

    public int ProductVariationId { get; set; }

    public int SupplierPricingGroupId { get; set; }

    public bool IsDefault { get; set; }

    public string? DividerImage { get; set; }

    public string? PaperStockImage { get; set; }

    public int? DefaultInkColorId { get; set; }

    public int StoreId { get; set; }

    public bool UseDefaultPricing { get; set; }

    public bool IsActive { get; set; }

    public string? VendorArtworkId { get; set; }

    public virtual TblProduct Product { get; set; } = null!;

    public virtual ProductVariation ProductVariation { get; set; } = null!;
}
