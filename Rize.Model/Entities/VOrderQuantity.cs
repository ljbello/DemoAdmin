using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class VOrderQuantity
{
    public long? OrderId { get; set; }

    public int? Quantity { get; set; }
}
