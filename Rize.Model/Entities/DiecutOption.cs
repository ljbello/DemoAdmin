using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class DiecutOption
{
    public int DieCutId { get; set; }

    public int VariationId { get; set; }

    public string DieCode { get; set; } = null!;

    public string AreaMode { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public string DisplayImage { get; set; } = null!;

    public int Width { get; set; }

    public int Height { get; set; }

    public int X { get; set; }

    public int Y { get; set; }

    public virtual ProductVariation Variation { get; set; } = null!;
}
