using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class OrderAdjustment
{
    public Guid OrderAdjustmentId { get; set; }

    public int OrderId { get; set; }

    public decimal Amount { get; set; }

    public string? Description { get; set; }

    public int? UserId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual TblUser? User { get; set; }
}
