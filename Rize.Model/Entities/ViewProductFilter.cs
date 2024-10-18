using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ViewProductFilter
{
    public int ProductId { get; set; }

    public bool? FilterNewCard { get; set; }

    public bool? FilterRecycled { get; set; }

    public bool? FilterFullColor { get; set; }

    public bool? FilterQuickStick { get; set; }

    public int StoStoreId { get; set; }
}
