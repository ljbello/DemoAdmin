using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductVariationSectionLayout
{
    public int ProductId { get; set; }

    public int ProductVariationId { get; set; }

    public int SectionId { get; set; }

    public int LayoutId { get; set; }

    public bool IsDefault { get; set; }

    public int? X { get; set; }

    public int? Y { get; set; }

    public int? Width { get; set; }

    public int? Height { get; set; }

    public virtual Layout Layout { get; set; } = null!;
}
