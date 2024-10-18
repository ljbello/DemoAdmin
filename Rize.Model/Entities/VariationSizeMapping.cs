using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class VariationSizeMapping
{
    public int Id { get; set; }

    public int SizeId { get; set; }

    public int VariationId { get; set; }

    public virtual TblSize Size { get; set; } = null!;

    public virtual ProductVariation Variation { get; set; } = null!;
}
