using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductOptionGroupExcludedPaperStockFinish
{
    public int VariationId { get; set; }

    public string GroupEntityDescriptor { get; set; } = null!;

    public int PaperStockFinishId { get; set; }
}
