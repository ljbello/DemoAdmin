using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblShippingMethodLookup
{
    public int? MethodLookupId { get; set; }

    public string? ServiceLevel { get; set; }

    public string? ShipMethod { get; set; }

    public int? ShippingMethodsId { get; set; }
}
