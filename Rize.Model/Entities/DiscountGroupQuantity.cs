using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class DiscountGroupQuantity
{
    public int DiscountGroupQuantityId { get; set; }

    public int StartQty { get; set; }

    public decimal DiscountAmount { get; set; }

    public int IncrementQty { get; set; }

    public int DiscountGroupId { get; set; }

    public DateTime CreatedOn { get; set; }

    public virtual DiscountGroup DiscountGroup { get; set; } = null!;
}
