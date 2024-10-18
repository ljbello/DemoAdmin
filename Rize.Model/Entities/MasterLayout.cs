using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class MasterLayout
{
    public int Id { get; set; }

    public int LayoutId { get; set; }

    public int VariationId { get; set; }

    public DateTime CreatedOn { get; set; }

    public virtual Layout Layout { get; set; } = null!;

    public virtual ProductVariation Variation { get; set; } = null!;
}
