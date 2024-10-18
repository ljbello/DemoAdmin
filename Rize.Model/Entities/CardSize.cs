using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class CardSize
{
    public int CardSizeId { get; set; }

    public string Name { get; set; } = null!;

    public bool? IsPv2 { get; set; }

    public bool? IsPv3 { get; set; }

    public int? ProductVariationId { get; set; }

    public int? SizeId { get; set; }

    public virtual ICollection<CardSizeSizeMapping> CardSizeSizeMappings { get; set; } = new List<CardSizeSizeMapping>();

    public virtual ProductVariation? ProductVariation { get; set; }

    public virtual TblSize? Size { get; set; }

    public virtual ICollection<SupplierCardSizeMapping> SupplierCardSizeMappings { get; set; } = new List<SupplierCardSizeMapping>();
}
