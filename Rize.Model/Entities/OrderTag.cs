using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class OrderTag
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public int TagId { get; set; }

    public int? OrderLineId { get; set; }

    public bool Value { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual TblOrderLine? OrderLine { get; set; }

    public virtual OrderTagKey Tag { get; set; } = null!;
}
