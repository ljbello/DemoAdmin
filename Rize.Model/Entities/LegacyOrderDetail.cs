using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class LegacyOrderDetail
{
    public long OrderNumber { get; set; }

    public int OrderDetailId { get; set; }

    public int? LineSequence { get; set; }

    public int? LineSubSequence { get; set; }

    public string? LineStatus { get; set; }

    public string? ShipMethod { get; set; }

    public string? ShipCarrier { get; set; }

    public string? GroupItem { get; set; }

    public string? Item { get; set; }

    public string? ItemDescription { get; set; }

    public int? Quantity { get; set; }

    public string? ShipAddr1 { get; set; }

    public string? ShipAddr2 { get; set; }

    public string? ShipAddrCity { get; set; }

    public string? ShipAddrState { get; set; }

    public string? ShipAddrZip { get; set; }

    public long? BarCode { get; set; }

    public int? ConvertedShipMethodId { get; set; }

    public int? ConvertedCarrierId { get; set; }
}
