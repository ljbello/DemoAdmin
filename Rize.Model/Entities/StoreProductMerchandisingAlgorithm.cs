using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class StoreProductMerchandisingAlgorithm
{
    public int ProductId { get; set; }

    public short StoreId { get; set; }

    public short MerchandisingSortingParameterId { get; set; }

    public int? MerchandisingSortingParameterValue { get; set; }

    public int? TimeFrameInDays { get; set; }

    public double? AlgorithmWeight { get; set; }

    public double? CalculatedValue { get; set; }

    public DateTime? ProcessedDate { get; set; }
}
