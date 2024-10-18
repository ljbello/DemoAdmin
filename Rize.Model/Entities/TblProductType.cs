using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblProductType
{
    public int ProTypProductTypeId { get; set; }

    public string ProTypDescription { get; set; } = null!;

    public string? ProductNumberPrefix { get; set; }

    public string? ImportProductTypeName { get; set; }

    public int? DefaultDiscountPricingGroupId { get; set; }

    public bool IsDigitalPress { get; set; }

    public int? DefaultQuantity { get; set; }

    public int? NewProductTypeId { get; set; }

    public bool? AllowAop { get; set; }
}
