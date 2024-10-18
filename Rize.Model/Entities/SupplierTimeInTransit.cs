using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierTimeInTransit
{
    public int SupplierId { get; set; }

    public string DestinationPostalCode { get; set; } = null!;

    public int DaysInTransit { get; set; }
}
