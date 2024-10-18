using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ShippingCostPredictionVariationWeight
{
    public int ProductVariationId { get; set; }

    public int PaperStockFinishId { get; set; }

    public decimal WeightPerCard { get; set; }

    public virtual PaperStockFinish PaperStockFinish { get; set; } = null!;

    public virtual ProductVariation ProductVariation { get; set; } = null!;
}
