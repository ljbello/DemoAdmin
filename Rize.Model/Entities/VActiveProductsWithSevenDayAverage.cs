using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class VActiveProductsWithSevenDayAverage
{
    public int ProProductId { get; set; }

    public int SupSupplierId { get; set; }

    public string? ProSupplierProductNumber { get; set; }

    public DateTime? ProSampleOnOrderDate { get; set; }

    public int ProStaProductStatusId { get; set; }

    public decimal? PreviousSevenDayAverage { get; set; }
}
