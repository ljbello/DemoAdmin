using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class VariationPriceGroupQuantity
{
    public int Id { get; set; }

    public int PriceGroupId { get; set; }

    public int LowerQty { get; set; }

    public int HigherQty { get; set; }

    public decimal CostPerPiece { get; set; }

    public int Increment { get; set; }

    public virtual VariationPricingGroup PriceGroup { get; set; } = null!;
}
