using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AutoProcessVariation
{
    public int VariationId { get; set; }

    public int StoreId { get; set; }

    public int Active { get; set; }

    public int? MaxQty { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public virtual Store Store { get; set; } = null!;

    public virtual ProductVariation Variation { get; set; } = null!;
}
