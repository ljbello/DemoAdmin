using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductVariationSection
{
    public int ProductId { get; set; }

    public int ProductVariationId { get; set; }

    public int SectionId { get; set; }

    public int Width { get; set; }

    public int Height { get; set; }

    public int PlateRotation { get; set; }

    public int PlateAnchor { get; set; }

    public string PreviewGroup { get; set; } = null!;

    public bool IsDefault { get; set; }

    public bool? Locked { get; set; }

    public bool IsDarkBackground { get; set; }

    public bool Shadow { get; set; }

    public virtual ProductVariation ProductVariation { get; set; } = null!;

    public virtual Section Section { get; set; } = null!;
}
