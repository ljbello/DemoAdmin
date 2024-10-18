using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ViewDppv3orderLinesRaw
{
    public int ProductId { get; set; }

    public int OrderLineId { get; set; }

    public int? VariationId { get; set; }

    public int PaperStock { get; set; }

    public int PaperFinish { get; set; }

    public int PaperStockFinishId { get; set; }
}
