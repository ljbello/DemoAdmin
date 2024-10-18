using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ViewDppv2orderLine
{
    public int OrderLineId { get; set; }

    public int ProductId { get; set; }

    public int CardSizeId { get; set; }

    public int PaperStockId { get; set; }

    public int PaperFinishId { get; set; }

    public int PaperStockFinishId { get; set; }
}
