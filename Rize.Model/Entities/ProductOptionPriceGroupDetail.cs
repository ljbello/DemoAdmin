using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductOptionPriceGroupDetail
{
    public int ProductOptionPriceGroupDetailId { get; set; }

    public string ProductOptionPriceGroupId { get; set; } = null!;

    public int LowerQuantityLimit { get; set; }

    public int UpperQuantityLimit { get; set; }

    public decimal AdditionalPricePerCard { get; set; }

    public string? EntityDescriptor { get; set; }

    public DateTime EntityCreated { get; set; }

    public string? FriendlyName { get; set; }

    public bool? IsDefault { get; set; }

    public int? PriceGroupId { get; set; }

    public string? SupplierSku { get; set; }

    public string? FriendlyDescription { get; set; }

    public string? ImageName { get; set; }

    public virtual ProductOptionPriceGroup? PriceGroup { get; set; }
}
