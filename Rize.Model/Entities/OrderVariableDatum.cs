using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class OrderVariableDatum
{
    public int OrderId { get; set; }

    public int OrderLineId { get; set; }

    public string Name { get; set; } = null!;

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Zip { get; set; } = null!;
}
