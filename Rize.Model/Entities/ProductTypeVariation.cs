using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductTypeVariation
{
    public int ProductTypeVariationId { get; set; }

    public int ProductTypeId { get; set; }

    public int ProductVariationId { get; set; }

    public virtual ProductType ProductType { get; set; } = null!;

    public virtual ProductVariation ProductVariation { get; set; } = null!;
}
