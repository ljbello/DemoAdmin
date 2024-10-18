using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class VProductConfiguration
{
    public int StoreId { get; set; }

    public int DiscountGroupId { get; set; }

    public int? ReviewCount { get; set; }

    public int? ProStaProductStatusId { get; set; }

    public DateTime? ActiveDate { get; set; }

    public int PreviewVersion { get; set; }

    public int ProductId { get; set; }

    public string ProductNumber { get; set; } = null!;

    public int? ManManufacturerId { get; set; }

    public int SupSupplierId { get; set; }

    public string? ProManufacturerProductNumber { get; set; }

    public string? ProDescription { get; set; }

    public int ProductTypeId { get; set; }

    public int ProductionTypeId { get; set; }

    public int? ThumbnailImageCount { get; set; }

    public int? EnvironmentImageCount { get; set; }

    public bool AllowCustomSample { get; set; }

    public bool? AllowFullColor { get; set; }

    public DateTime ProDateAdded { get; set; }

    public int ProductVariationId { get; set; }

    public string VariationName { get; set; } = null!;

    public bool? Preconverted { get; set; }

    public bool? ShowPrintSafe { get; set; }

    public bool? AllowAddressing { get; set; }

    public bool? AllowMailing { get; set; }

    public string? PlateType { get; set; }

    public bool AllowStamping { get; set; }

    public string? ShortName { get; set; }

    public double Width { get; set; }

    public double Height { get; set; }

    public int SectionId { get; set; }

    public int LayoutId { get; set; }

    public int? LayoutWidth { get; set; }

    public int? LayoutHeight { get; set; }

    public int? X { get; set; }

    public int? Y { get; set; }

    public int AreaId { get; set; }

    public string? AreaMode { get; set; }

    public int AreaTypeId { get; set; }

    public int? DefaultVerseId { get; set; }

    public string? PreviewImage { get; set; }

    public string? PlateImage { get; set; }

    public string? AreaText { get; set; }

    public int SupplierPricingGroupId { get; set; }

    public int SectionWidth { get; set; }

    public int SectionHeight { get; set; }

    public bool? Locked { get; set; }

    public bool SectionIsDefault { get; set; }

    public string PreviewGroup { get; set; } = null!;

    public bool IsDarkBackground { get; set; }
}
