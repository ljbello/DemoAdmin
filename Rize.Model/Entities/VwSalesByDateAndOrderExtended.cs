using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class VwSalesByDateAndOrderExtended
{
    public int OrdOrderId { get; set; }

    public string? OrderNumber { get; set; }

    public DateTime? OrderDate { get; set; }

    public DateTime? OrdPlacedDate { get; set; }

    public string? CusAddCompany { get; set; }

    public int? IOrderTotalPieces { get; set; }

    public int? IOrderTotalQuantity { get; set; }

    public decimal Settlement { get; set; }

    public decimal? InvoiceTotal { get; set; }

    public int? InvoiceCount { get; set; }

    public decimal? Profit { get; set; }

    public decimal? ProfitPercentage { get; set; }

    public DateTime? EarliestShipDate { get; set; }

    public string? FulfillmentCenters { get; set; }

    public DateTime? LargestShipDate { get; set; }
}
