using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class VAutoTriggerDatum
{
    public int OrderId { get; set; }

    public string? ContactEmail { get; set; }

    public string? ContactFirstName { get; set; }

    public string? ContactLastName { get; set; }

    public decimal SettlementAmount { get; set; }

    public int? Quantity { get; set; }

    public decimal? AdjustmentAmount { get; set; }

    public decimal? CreditAmount { get; set; }

    public string ProductNumber { get; set; } = null!;

    public string ProductType { get; set; } = null!;

    public string BillingAddress { get; set; } = null!;

    public string BillingZip { get; set; } = null!;

    public string BillingState { get; set; } = null!;

    public string ShippingAddress { get; set; } = null!;

    public string ShippingZip { get; set; } = null!;

    public string ShippingState { get; set; } = null!;

    public string? ShippingCompany { get; set; }

    public string? VariationName { get; set; }

    public int? ProductVariationId { get; set; }

    public string? PromoCode { get; set; }

    public string? PaperType { get; set; }

    public string ShipMethod { get; set; } = null!;

    public int StoreId { get; set; }

    public DateTime? PlacedDate { get; set; }

    public string? PromoType { get; set; }

    public int ProductTypeId { get; set; }

    public int? DisTypDiscountTypeId { get; set; }

    public int ShiMetShippingMethodId { get; set; }

    public int SupplierId { get; set; }
}
