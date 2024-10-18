using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ShippingPricingGroup
{
    public int Id { get; set; }

    public int LowQuantity { get; set; }

    public int HighQuantity { get; set; }

    public decimal CostPerPiece { get; set; }
}
