using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class VOrderQuanityByOrderLineId
{
    public int OrdOrderId { get; set; }

    public int OrdLinOrderLineId { get; set; }

    public int? Quantity { get; set; }
}
