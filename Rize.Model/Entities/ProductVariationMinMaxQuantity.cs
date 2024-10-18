using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductVariationMinMaxQuantity
{
    public int Id { get; set; }

    public int? VariationId { get; set; }

    public int StoreId { get; set; }

    public int MinQuantity { get; set; }

    public int MaxQuantity { get; set; }

    public int ProductTypeId { get; set; }

    public virtual Store Store { get; set; } = null!;

    public virtual ProductVariation? Variation { get; set; }
}
