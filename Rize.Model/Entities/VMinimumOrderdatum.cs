using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class VMinimumOrderdatum
{
    public int OrdOrderId { get; set; }

    public string? OrderNumber { get; set; }

    public int OrdlinOrderlineid { get; set; }

    public string? OrdEnteredBy { get; set; }
}
