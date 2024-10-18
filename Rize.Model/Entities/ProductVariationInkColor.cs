using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductVariationInkColor
{
    public int ProductVariationId { get; set; }

    public int InkColorId { get; set; }

    public short IsDefault { get; set; }
}
