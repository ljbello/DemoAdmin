using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class StoreShippingGlobalRate
{
    public int Id { get; set; }

    public int StoreId { get; set; }

    public int ShippingMethodId { get; set; }

    public string Type { get; set; } = null!;

    public decimal Low { get; set; }

    public decimal High { get; set; }

    public bool Multiplier { get; set; }

    public decimal FlatRate { get; set; }

    public bool Active { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime ModifiedOn { get; set; }

    public int ModifiedBy { get; set; }
}
