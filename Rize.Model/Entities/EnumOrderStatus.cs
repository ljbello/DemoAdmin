using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class EnumOrderStatus
{
    public int OrderStatusesId { get; set; }

    public string OrderStatusesName { get; set; } = null!;

    public string? OrderStatusesDescription { get; set; }
}
