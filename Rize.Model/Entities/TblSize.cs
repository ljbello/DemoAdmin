using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblSize
{
    public int SizSizeId { get; set; }

    public string SizDescription { get; set; } = null!;

    public int ProTypProductTypeId { get; set; }

    public string? SizImageViewCode { get; set; }

    public virtual ICollection<CardSizeSizeMapping> CardSizeSizeMappings { get; set; } = new List<CardSizeSizeMapping>();

    public virtual ICollection<CardSize> CardSizes { get; set; } = new List<CardSize>();

    public virtual ProductType ProTypProductType { get; set; } = null!;

    public virtual ICollection<TblChristmasCard> TblChristmasCards { get; set; } = new List<TblChristmasCard>();

    public virtual ICollection<VariationSizeMapping> VariationSizeMappings { get; set; } = new List<VariationSizeMapping>();
}
