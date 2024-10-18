using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class OrderStatusFriendly
{
    public short OrderStatusFriendlyId { get; set; }

    public string? TextColor { get; set; }

    public bool? OnHold { get; set; }

    public string? StatusDescription { get; set; }

    public string? StatusDetails { get; set; }
}
