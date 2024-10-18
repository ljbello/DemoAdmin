using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class CharityOrder
{
    public int CharityOrderId { get; set; }

    public int OrderId { get; set; }

    public string AssociatedCharity { get; set; } = null!;
}
