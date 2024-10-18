using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ShippingCostPredictionBoxWeight
{
    public int SupplierId { get; set; }

    public int ProductVariationId { get; set; }

    public string BoxType { get; set; } = null!;

    public int MaxCardsPerBox { get; set; }

    public decimal WeightPerBox { get; set; }
}
