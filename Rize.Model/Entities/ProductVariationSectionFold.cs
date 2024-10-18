using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductVariationSectionFold
{
    public int Id { get; set; }

    public int VariationId { get; set; }

    public int SectionId { get; set; }

    public int Ordinal { get; set; }

    public string Orientation { get; set; } = null!;

    public int X { get; set; }

    public int Y { get; set; }

    public bool Visible { get; set; }

    public virtual ProductVariation Variation { get; set; } = null!;
}
