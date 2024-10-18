using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class OrderLineCostPrediction
{
    public int OrderLineId { get; set; }

    public string ProcessingStatus { get; set; } = null!;

    public int OrderId { get; set; }

    public string OrderNumber { get; set; } = null!;

    public int OrderPartId { get; set; }

    public int SupplierId { get; set; }

    public int Quantity { get; set; }

    public int ProductId { get; set; }

    public string ProductNumber { get; set; } = null!;

    public string? SupplierProductNumber { get; set; }

    public decimal? ActualCardUnitPrice { get; set; }

    public string? ActualCardSupplierPartId { get; set; }

    public decimal? ActualEnvelopeUnitPrice { get; set; }

    public string? ActualEnvelopeSupplierPartId { get; set; }

    public decimal? ActualInvoiceSubTotals { get; set; }

    public decimal? ActualInvoiceCreditsAndDebits { get; set; }

    public decimal? ActualInvoiceShipping { get; set; }

    public decimal? ExpectedCardCost { get; set; }

    public decimal? ActualCardCost { get; set; }

    public decimal? ExpectedEnvelopeCost { get; set; }

    public decimal? ActualEnvelopeCost { get; set; }

    public decimal? ExpectedCardFoilCharge { get; set; }

    public decimal? ActualCardFoilCharge { get; set; }

    public decimal? ExpectedEnvelopeFoilCharge { get; set; }

    public decimal? ActualEnvelopeFoilCharge { get; set; }

    public decimal? ExpectedPmsinkCharge { get; set; }

    public decimal? ActualPmsinkCharge { get; set; }

    public decimal? ExpectedTwoColorCharge { get; set; }

    public decimal? ActualTwoColorCharge { get; set; }

    public decimal? ExpectedRegistrationCharge { get; set; }

    public decimal? ActualRegistrationCharge { get; set; }

    public decimal? ExpectedTotal { get; set; }

    public decimal? ActualTotalPossiblyInvalid { get; set; }
}
