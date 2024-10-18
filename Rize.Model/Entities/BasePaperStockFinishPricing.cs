using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class BasePaperStockFinishPricing
{
    public int PaperStockFinishId { get; set; }

    public int LowerQuantityLimit { get; set; }

    public int UpperQuantityLimit { get; set; }

    public int PaperStockId { get; set; }

    public int PaperFinishId { get; set; }

    public string ProductOptionPriceGroupId { get; set; } = null!;

    public string? InternalName { get; set; }

    public string? DisplayName { get; set; }

    public decimal AdditionalPricePerCard { get; set; }

    public int StoreId { get; set; }
}
