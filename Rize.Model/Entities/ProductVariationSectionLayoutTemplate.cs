using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductVariationSectionLayoutTemplate
{
    public int ProductVariationId { get; set; }

    public int SectionId { get; set; }

    public int LayoutId { get; set; }

    public bool IsDefault { get; set; }

    public int? ClipX { get; set; }

    public int? ClipY { get; set; }

    public int? Width { get; set; }

    public int? Height { get; set; }
}
