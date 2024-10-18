using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ReportGetOrderlineCostPredictionView
{
    public int OrderLineId { get; set; }

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

    public decimal? DiffCardCost { get; set; }

    public decimal? DiffPercentCardCost { get; set; }

    public decimal? ExpectedEnvelopeCost { get; set; }

    public decimal? ActualEnvelopeCost { get; set; }

    public decimal? DiffEnvelopeCost { get; set; }

    public decimal? DiffPercentEnvelopeCost { get; set; }

    public decimal? ExpectedCardFoilCharge { get; set; }

    public decimal? ActualCardFoilCharge { get; set; }

    public decimal? DiffCardFoilCharge { get; set; }

    public decimal? DiffPercentCardFoilCharge { get; set; }

    public decimal? ExpectedEnvelopeFoilCharge { get; set; }

    public decimal? ActualEnvelopeFoilCharge { get; set; }

    public decimal? DiffEnvelopeFoilCharge { get; set; }

    public decimal? DiffPercentEnvelopeFoilCharge { get; set; }

    public decimal? ExpectedPmsinkCharge { get; set; }

    public decimal? ActualPmsinkCharge { get; set; }

    public decimal? DiffPmscharge { get; set; }

    public decimal? DiffPercentPmscharge { get; set; }

    public decimal? ExpectedTwoColorCharge { get; set; }

    public decimal? ActualTwoColorCharge { get; set; }

    public decimal? DiffTwoColorCharge { get; set; }

    public decimal? DiffPercentTwoColorCharge { get; set; }

    public decimal? ExpectedRegistrationCharge { get; set; }

    public decimal? ActualRegistrationCharge { get; set; }

    public decimal? DiffRegistrationCharge { get; set; }

    public decimal? DiffPercentRegistrationCharge { get; set; }

    public decimal? ExpectedTotal { get; set; }

    public decimal? ActualTotalPossiblyInvalid { get; set; }

    public decimal? DiffTotal { get; set; }

    public decimal? DiffPercentTotal { get; set; }

    public string? FriendlyName { get; set; }

    public string? DisplayName { get; set; }

    public string? FullColorEnvelopeCode { get; set; }

    public string? Pv3envelopeText { get; set; }

    public decimal? AmountDollarDiffByQty { get; set; }

    public string ProcessingStatus { get; set; } = null!;

    public decimal? OrderTotal { get; set; }

    public decimal? OrderAdjustments { get; set; }

    public decimal? TotalSettlementAmount { get; set; }

    public decimal? TotalInvoice { get; set; }

    public decimal? OrdAdditionalDiscountTotal { get; set; }

    public string ProfitDollar { get; set; } = null!;

    public string ProfitPercent { get; set; } = null!;

    public string Notes { get; set; } = null!;
}
