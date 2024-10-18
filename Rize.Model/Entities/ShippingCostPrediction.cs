using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ShippingCostPrediction
{
    public int OrderPartId { get; set; }

    public int OrderId { get; set; }

    public string OrderNumber { get; set; } = null!;

    public int SupplierId { get; set; }

    public int ShippingCarrierId { get; set; }

    public int ShippingMethodId { get; set; }

    public string ShipFromZip { get; set; } = null!;

    public string ShipToZip { get; set; } = null!;

    public decimal CalculatedWeight { get; set; }

    public decimal ShippingCost { get; set; }

    public string? ShippingRequestErrorMessage { get; set; }
}
