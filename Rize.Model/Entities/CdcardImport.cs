using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class CdcardImport
{
    public int IId { get; set; }

    public string? Category { get; set; }

    public DateTime? DateStockExpected { get; set; }

    public string? Album { get; set; }

    public string? PageNumber { get; set; }

    public string MasterListNumber { get; set; } = null!;

    public string? ManufacturerCode { get; set; }

    public string? PureCardNumber { get; set; }

    public string? Description { get; set; }

    public string? PricePoint { get; set; }

    public string? Env { get; set; }

    public string? FastickEnvelopes { get; set; }

    public string? EnvelopeDescription { get; set; }

    public string? PreversedOrBlank { get; set; }

    public string? Ink { get; set; }

    public int? IMatchingSupPriPricingGroupId { get; set; }

    public string? Orientation { get; set; }

    public string? Size { get; set; }

    public int? IMatchingManManufacturerId { get; set; }

    public string? RepeatOrNew { get; set; }

    public string? PhotoOrDesign { get; set; }

    public string? ImageBaseName { get; set; }

    public int? DiscountPricingGroupId { get; set; }

    public int? SupplierPriceGroupId { get; set; }

    public int? SellingPriceGroupId { get; set; }

    public int? VerseScaleFactor { get; set; }

    public bool? Recycled { get; set; }

    public string? VerseGroup { get; set; }

    public string? DefaultVerse { get; set; }

    public string? ProductName { get; set; }

    public int? StockCode { get; set; }

    public int StoreId { get; set; }

    public bool? HolidayCard { get; set; }

    public int? I123PrintTypeId { get; set; }

    public int? I123PrintThemeId { get; set; }

    public int PreviewVersion { get; set; }
}
