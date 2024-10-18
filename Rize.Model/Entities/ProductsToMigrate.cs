using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductsToMigrate
{
    public int? StoreId { get; set; }

    public int? ProductId { get; set; }

    public string? ProductNumber { get; set; }

    public int? ManId { get; set; }

    public string? ManItemNumber { get; set; }

    public string? ManProductNumber { get; set; }

    public int? VariationId { get; set; }

    public string? Dimensions { get; set; }

    public int? PaperStockFinishId { get; set; }

    public int? SupplierEnvelopeId { get; set; }

    public string? SupplierEnvelopeCode { get; set; }

    public int? AltEnvelopeId { get; set; }

    public double? Width { get; set; }

    public double? Height { get; set; }

    public double? WidthSize { get; set; }

    public double? HeightSize { get; set; }

    public string? CardOrientation { get; set; }

    public int? VerseId { get; set; }

    public bool? IsPanel { get; set; }

    public bool? IsDieCut { get; set; }

    public bool? IsDieCutLogo { get; set; }

    public bool? IsCalendarCard { get; set; }

    public int? InkColorId { get; set; }

    public string? InkColorName { get; set; }

    public int? CardFontSize { get; set; }

    public int? EnvelopeFontSize { get; set; }

    public string? DefaultFont { get; set; }

    public int? FrontFontSize { get; set; }

    public string? DefaultFontColor { get; set; }

    public string? FrontImage { get; set; }

    public string? BackImage { get; set; }

    public string? Inside1Image { get; set; }

    public string? Inside2Image { get; set; }

    public bool? IsMigrated { get; set; }

    public bool? IsError { get; set; }

    public string? ErrorMessage { get; set; }
}
