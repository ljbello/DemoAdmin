using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class VOrdersWithAllNonPreviewOrderLine
{
    public int OrdOrderId { get; set; }

    public int? TotalQuantity { get; set; }
}
