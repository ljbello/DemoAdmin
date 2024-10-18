using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class PersonalizationLayoutImport
{
    public double? ProductId { get; set; }

    public string? ProductVariation { get; set; }

    public string? Section { get; set; }

    public bool? DefaultSectionForThisVariation { get; set; }

    public double? Width { get; set; }

    public double? Height { get; set; }

    public double? PlateRotation { get; set; }

    public string? PlateAnchor { get; set; }

    public string? PreviewGroup { get; set; }

    public string? LayoutGroup { get; set; }

    public double? LayoutIcon { get; set; }

    public bool? DefaultLayoutForThisSection { get; set; }

    public double? DtaTop { get; set; }

    public double? DtaLeft { get; set; }

    public double? AreaWidth { get; set; }

    public double? AreaHeight { get; set; }

    public string? AreaType { get; set; }

    public string? AreaName { get; set; }

    public bool? AllowVerse { get; set; }

    public string? AreaMode { get; set; }

    public string? VerticalAlignment { get; set; }

    public string? HorizontalAlignment { get; set; }

    public string? Orientation { get; set; }

    public string? Artwork { get; set; }

    public string? ArtworkName { get; set; }

    public string? ArtworkMaskName { get; set; }

    public bool? DropShadow { get; set; }

    public string? DividerImage { get; set; }

    public string? PaperStockImage { get; set; }

    public bool? BlankVerse { get; set; }

    public string? AreaText { get; set; }

    public int? StoreId { get; set; }

    public string? PriceId { get; set; }
}
